Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Mission : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Public orderNumber As Integer
    Public pile As String
    Public imgFront As String
    Public backVis = False
    Dim imgBack As String
    Public imageFront As Image
    Public imageBack As Image
    Public wide As Boolean = False
    Public rotated As Boolean = False

    Public Sub New()
        Width = 43
        Height = 60
        pile = "Reserve"
        Visible = False
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal mID As Integer, ByVal number As Integer)
        ID = mID
        orderNumber = number
        pile = "Reserve"
        Visible = False
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.missionsDataTable
        Dim da As New OPCardsDataSetTableAdapters.missionsTableAdapter
        Dim dr As New DataTableReader(dt)

        'find mission set in database using ID and fill table
        da.FillByIDandNumber(dt, id, number)

        'add mission's data
        Using dr
            While dr.Read
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
                imgBack = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image_back"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        imgBack = imgBack.Replace("/", "\")
        imageFront = Image.FromFile(imgFront)
        Image = imageFront
        imageBack = Image.FromFile(imgBack)
    End Sub

    Public Sub Parse(ByVal mID As Integer, ByVal number As Integer)
        ID = mID
        orderNumber = number
        pile = "Reserve"
        Visible = True

        Dim dt As New OPCardsDataSet.missionsDataTable
        Dim da As New OPCardsDataSetTableAdapters.missionsTableAdapter
        Dim dr As New DataTableReader(dt)

        'find mission set in database using ID and fill table
        da.FillByIDandNumber(dt, id, number)

        'add mission's data to existing table card
        Using dr
            While dr.Read
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
                imgBack = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image_back"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        imgBack = imgBack.Replace("/", "\")
        imageFront = Image.FromFile(imgFront)
        Image = imageFront
        imageBack = Image.FromFile(imgBack)
    End Sub

    Public Function Rotate()
        Dim img As Image
        img = Image
        img.RotateFlip(RotateFlipType.Rotate180FlipNone)
        Return img
    End Function
End Class
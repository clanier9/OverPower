Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Location : Inherits System.Windows.Forms.PictureBox
    Dim ID As Integer
    Public locName As String
    Public inherent As String
    Public wide As Boolean = True
    Dim imgFront As String
    Public rotated As Boolean = False
    Public commonname As String
    Public KO = False

    Public Sub New()
        Width = 128
        Height = 91
        Visible = False
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal locID As Integer)
        ID = locID
        Visible = False
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.homebasesDataTable
        Dim da As New OPCardsDataSetTableAdapters.homebasesTableAdapter
        Dim dr As New DataTableReader(dt)

        'find location in database using ID and fill table
        da.FillByID(dt, ID)

        'add location's data
        Using dr
            While dr.Read
                locName = dr.GetString(dr.GetOrdinal("name"))
                inherent = dr.GetString(dr.GetOrdinal("inherent"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        Image = Image.FromFile(imgFront)
    End Sub

    Public Sub Parse(ByVal locID As Integer)
        ID = locID
        Visible = True

        Dim dt As New OPCardsDataSet.homebasesDataTable
        Dim da As New OPCardsDataSetTableAdapters.homebasesTableAdapter
        Dim dr As New DataTableReader(dt)

        'find location in database using ID and fill table
        da.FillByID(dt, ID)

        'add location's data to existing table card
        Using dr
            While dr.Read
                locName = dr.GetString(dr.GetOrdinal("name"))
                inherent = dr.GetString(dr.GetOrdinal("inherent"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        Image = Image.FromFile(imgFront)
    End Sub
End Class

Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Doubleshot : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Dim type As Char
    Dim toUseValue As Integer = 6
    Dim value As Integer = 4
    Public wide As Boolean = False
    Public placed As Boolean = False
    Public played As Boolean = False
    Public hit As Boolean = False
    Public perm As Boolean = False
    Public attack As Boolean = False
    Public defend As Boolean = False
    Public placedOn As String
    Public hitOn As String
    Public commonname As String
    Public rotated = False

    Public ImageFront As Image
    Dim imgFront As String
    Dim imgBack As String

    Public Sub New()
        Width = 64
        Height = 90
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal dsID As Integer)
        ID = dsID
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.doubleshotDataTable
        Dim da As New OPCardsDataSetTableAdapters.doubleshotTableAdapter
        Dim dr As New DataTableReader(dt)

        'find doubleshot in database using ID and fill table
        da.FillByID(dt, ID)

        'add doubleshot's data
        Using (dr)
            While (dr.Read)
                type = dr.GetString(dr.GetOrdinal("touse_skill"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        ImageFront = Image.FromFile(imgFront)
        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        Image = ImageFront

        commonname = commonname.Substring(0, 22)
    End Sub
End Class
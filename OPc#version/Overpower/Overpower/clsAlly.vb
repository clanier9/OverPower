Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Ally : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Dim toUseType As Char
    Dim toUseValue As Integer
    Dim type As Char
    Dim value As Integer
    Dim lessThan As Boolean
    Dim imgFront As String
    Dim imgBack As String
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

    Public Sub New()
        Width = 64
        Height = 90
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage
        Location = Cursor.Position
    End Sub

    Public Sub New(ByVal aid As Integer)
        ID = aid
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.allyDataTable
        Dim da As New OPCardsDataSetTableAdapters.allyTableAdapter
        Dim dr As New DataTableReader(dt)

        'find ally card in database using ID and fill table
        da.FillByID(dt, ID)

        'add ally card's data
        Using (dr)
            While (dr.Read)
                toUseType = dr.GetString(dr.GetOrdinal("touse_skill"))
                toUseValue = dr.GetInt32(dr.GetOrdinal("touse_power"))
                type = dr.GetString(dr.GetOrdinal("actas_skill"))
                value = dr.GetInt32(dr.GetOrdinal("actas_power"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        'not sure why I originally put this in
        If toUseValue = 5 Then
            lessThan = True
        End If

        imgFront = imgFront.Replace("/", "\")
        ImageFront = Image.FromFile(imgFront)
        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        Image = ImageFront

        commonname = commonname.Substring(0, 11)
    End Sub
End Class
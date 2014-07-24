Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class PowerCard : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Dim value As Integer
    Dim type As Char
    Dim opd As Boolean
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

    Public Sub New(ByVal pcID As Integer)
        ID = pcID
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.powerDataTable
        Dim da As New OPCardsDataSetTableAdapters.powerTableAdapter
        Dim dr As New DataTableReader(dt)

        'find power card in database using ID and fill table
        da.FillByID(dt, ID)

        'add power card's data
        Using (dr)
            While (dr.Read)
                value = dr.GetInt32(dr.GetOrdinal("value"))
                type = dr.GetString(dr.GetOrdinal("skill"))
                opd = dr.GetInt32(dr.GetOrdinal("opd"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        ImageFront = Image.FromFile(imgFront)
        Image = ImageFront

        Dim skill As String = ""
        If type = "E" Then
            skill = "Energy"
        ElseIf type = "F" Then
            skill = "Fighting"
        ElseIf type = "S" Then
            skill = "Strength"
        ElseIf type = "I" Then
            skill = "Intellect"
        ElseIf type = "M" Then
            skill = "Multipower"
        ElseIf type = "A" Then
            skill = "Anypower"
        End If
        commonname = "Power Card: " + value.ToString + " " + skill
    End Sub
End Class

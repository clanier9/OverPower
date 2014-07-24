Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Teamwork : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Dim toUseType As Char
    Dim toUseValue As Integer
    Dim value As Integer = 6
    Dim bonusType1 As Char
    Dim bonus1 As Integer
    Dim bonusType2 As Char
    Dim bonus2 As Integer
    Dim bonus As Integer
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

    Public Sub New(ByVal twID As Integer)
        ID = twID
        Visible = False
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.teamworkDataTable
        Dim da As New OPCardsDataSetTableAdapters.teamworkTableAdapter
        Dim dr As New DataTableReader(dt)

        'find teamwork in database using ID and fill table
        da.FillByID(dt, ID)

        'add teamwork's data
        Using (dr)
            While (dr.Read)
                toUseType = dr.GetString(dr.GetOrdinal("touse_skill"))
                toUseValue = dr.GetInt32(dr.GetOrdinal("touse_power"))
                bonusType1 = dr.GetString(dr.GetOrdinal("teammate1_skill"))
                bonus1 = dr.GetInt32(dr.GetOrdinal("teammate1_bonus"))
                bonusType2 = dr.GetString(dr.GetOrdinal("teammate2_skill"))
                bonus2 = dr.GetInt32(dr.GetOrdinal("teammate2_bonus"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgBack = "http://overpower.ca/cards/misc/op_back.png"
        imgFront = imgFront.Replace("/", "\")
        ImageFront = Image.FromFile(imgFront)
        Image = ImageFront

        commonname = commonname.Substring(0, 20)
    End Sub
End Class

Imports System.Windows.Forms
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

<Serializable> Public Class Character : Inherits System.Windows.Forms.PictureBox
    Public ID As Integer
    Dim imgFront As String
    Public cName As String
    Public cID As Integer
    Dim energy As Integer
    Dim fighting As Integer
    Dim strength As Integer
    Dim intellect As Integer
    Dim total As Integer
    Public inherent As String
    Dim hitPoints As Integer = 20
    Dim hitTypes As Integer = 0
    Public wide As Boolean = True
    Public placed As Boolean = False
    Public played As Boolean = False
    Public hit As Boolean = False
    Public perm As Boolean = False
    Public attack As Boolean = False
    Public defend As Boolean = False
    Public placedOn As String
    Public hitOn As String
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

    Public Sub New(ByVal chID As Integer)
        ID = chID
        Visible = False
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Anchor = AnchorStyles.None
        SizeMode = PictureBoxSizeMode.StretchImage

        Dim dt As New OPCardsDataSet.charactersDataTable
        Dim da As New OPCardsDataSetTableAdapters.charactersTableAdapter
        Dim dr As New DataTableReader(dt)

        'find character in database using ID and fill table
        da.FillByID(dt, ID)

        'add character's data
        Using dr
            While dr.Read
                cName = dr.GetString(dr.GetOrdinal("name_on_card"))
                cID = dr.GetInt32(dr.GetOrdinal("uid"))
                energy = dr.GetInt32(dr.GetOrdinal("e"))
                fighting = dr.GetInt32(dr.GetOrdinal("f"))
                strength = dr.GetInt32(dr.GetOrdinal("s"))
                intellect = dr.GetInt32(dr.GetOrdinal("i"))
                total = dr.GetInt32(dr.GetOrdinal("total"))
                inherent = dr.GetString(dr.GetOrdinal("inherent"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
                commonname = dr.GetString(dr.GetOrdinal("commonname"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        Image = Image.FromFile(imgFront)
        cName = Replace(cName, " (3 GRID)", "")
        cName = Replace(cName, " (Promo)", "")
        cName = Replace(cName, " (Hillshire Farm)", "")
        commonname = "Character: " + cName
    End Sub

    Public Sub Parse(ByVal chID As Integer)
        ID = chID

        Dim dt As New OPCardsDataSet.charactersDataTable
        Dim da As New OPCardsDataSetTableAdapters.charactersTableAdapter
        Dim dr As New DataTableReader(dt)

        'find character in database using ID and fill table
        da.FillByID(dt, ID)

        'add character's data to existing table card
        Using dr
            While dr.Read
                cName = dr.GetString(dr.GetOrdinal("name_on_card"))
                cID = dr.GetInt32(dr.GetOrdinal("uid"))
                energy = dr.GetInt32(dr.GetOrdinal("e"))
                fighting = dr.GetInt32(dr.GetOrdinal("f"))
                strength = dr.GetInt32(dr.GetOrdinal("s"))
                intellect = dr.GetInt32(dr.GetOrdinal("i"))
                total = dr.GetInt32(dr.GetOrdinal("total"))
                inherent = dr.GetString(dr.GetOrdinal("inherent"))
                imgFront = Application.StartupPath + "\Card Images\" + dr.GetString(dr.GetOrdinal("image"))
            End While
        End Using

        imgFront = imgFront.Replace("/", "\")
        Image = Image.FromFile(imgFront)
        KO = False
        Visible = True
        cName = Replace(cName, " (3 GRID)", "")
        cName = Replace(cName, " (Promo)", "")
        cName = Replace(cName, " (Hillshire Farm)", "")
        commonname = "Character: " + cName
    End Sub
End Class

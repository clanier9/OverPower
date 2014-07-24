<Serializable> Public Class Cereal
    Public id As Integer
    Public cardType As String
    Public attacker As String
    Public defender As String
    Public shifted As Boolean
    Public placedOn As String
    Public playedOn As String
    Public attack As Boolean
    Public faceDown As Boolean
    Public defend As Boolean
    Public placed As Boolean
    Public played As Boolean
    Public hit As Boolean
    Public perm As Boolean
    Public discard As Boolean
    Public text As String
    Public command As String
    Public remove As Boolean
    Public fromHand As Boolean
    Public fromPlaced As Boolean
    Public fromPile As String
    Public toPile As String
    Public backToHand As Boolean
    Public OppUserID As String
    Public OppGender As String
    Public hasDeck As Boolean
    Public hasBsDeck As Boolean
    Public hasChars As Boolean
    Public deck As Collection
    Public bsDeck As Collection
    Public chars As Collection
    Public hasImage1 As Boolean
    Public hasImage2 As Boolean
    Public Image1 As Integer
    Public Image2 As Integer
    Public wide1 As Boolean
    Public wide2 As Boolean
    Public toPerm As Boolean
    Public hitOn As String
    Public hasVenture As Boolean
    Public Venture As String
    Public hasHand As Boolean
    Public hand As Collection
    Public mID As Integer
    Public ko As Boolean
    Public charKOd As String
    Public move As Boolean
    Public moveFrom As String
    Public moveTo As String
    Public rez As Boolean

    Public Sub New()

    End Sub
End Class

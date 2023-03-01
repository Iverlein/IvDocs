Sub FormatDocument()
    Dim oList As List
    oInlineShape As InlineShape
    
    ' Format numbered list
    For Each oList In ActiveDocument.Lists
        oList.Range.Style = "MES_List_NUM"
    Next oList
    
    ' Format pictures
    For Each oInlineShape In ActiveDocument.InlineShapes
            oInlineShape.Height = CentimetersToPoints(8.37)
            oInlineShape.Width = CentimetersToPoints(16.48)
    Next oInlineShape
End Sub
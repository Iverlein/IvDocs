Sub DefineTableColumns()
    Dim tbl As Table
    Dim col As Column
    Dim i As Integer
    Dim columnWidths As Variant
    
    'Get the selected table
    Set tbl = Selection.Tables(1)
    
    'Set the column widths (in centimeters)
    columnWidths = Array(2.5, 5, 3, 4)
    
    'Loop through each column and set the width
    For i = 1 To tbl.Rows(1).Cells.Count
        Set col = tbl.Columns(i)
        
        'Check if the column width is defined in the array
        If i <= UBound(columnWidths) Then
            'Set the column width to the specified value (in centimeters)
            col.SetWidth ColumnWidth:=CentimetersToPoints(columnWidths(i - 1)), RulerStyle:=wdAdjustNone
        Else
            'If the column width is not defined in the array, set the width to 0 (minimum width)
            col.SetWidth ColumnWidth:=0, RulerStyle:=wdAdjustNone
        End If
    Next i
    
    'Set the text style for the entire table
    tbl.Range.Style = "MES_Table_text"
End Sub

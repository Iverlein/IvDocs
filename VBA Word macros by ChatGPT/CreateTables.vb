Sub CreateTablesWithRowsColumnsAndTextStyles()
    Dim numTables As Integer ' Number of tables to create
    Dim numRows As Integer ' Number of rows in each table
    Dim numCols As Integer ' Number of columns in each table
    Dim i As Integer ' Loop counter
    Dim j As Integer ' Loop counter
    Dim curTable As Table ' Current table being created
    Dim curCell As Cell ' Current cell being formatted
    
    ' Prompt user for number of tables, rows, and columns
    numTables = InputBox("Enter the number of tables to create:")
    numRows = InputBox("Enter the number of rows in each table:")
    numCols = InputBox("Enter the number of columns in each table:")
    
    ' Create the specified number of tables
    For i = 1 To numTables
        ' Insert a table with the specified number of rows and columns
        Set curTable = ActiveDocument.Tables.Add(Selection.Range, numRows, numCols)
        
        ' Format the table with borders and shading
        curTable.Borders.InsideLineStyle = wdLineStyleSingle
        curTable.Borders.OutsideLineStyle = wdLineStyleSingle
        curTable.Shading.Texture = wdTextureNone
        curTable.Shading.BackgroundPatternColor = wdColorAutomatic
        
        ' Apply text styles to cells
        For j = 1 To curTable.Range.Cells.Count
            Set curCell = curTable.Range.Cells(j)
            curCell.Range.Font.Name = "Times New Roman"
            curCell.Range.Font.Size = 12
            curCell.Range.Font.Bold = True
            curCell.Range.ParagraphFormat.Alignment = wdAlignParagraphCenter
        Next j
        
        ' Move to the next table
        Selection.MoveDown Unit:=wdTable
    Next i
End Sub

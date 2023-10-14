
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Office.Interop.Excel;
namespace MLCompare
{
    public static class InputReaderOpenXML
    {
         public static void ReadExcelFileDOM(string fileName)
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                string text;
                foreach (Row r in sheetData.Elements<Row>())
                {
                    foreach (Cell c in r.Elements<Cell>())
                    {
                        text = c.CellValue.Text;
                        Console.Write(text + " ");
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }

        // The SAX approach.
        public static void ReadExcelFileSAX(string fileName)
        {
            string s = "";
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();

                OpenXmlReader reader = OpenXmlReader.Create(worksheetPart);
                string text;
                while (reader.Read())
                {
                    if (reader.ElementType == typeof(CellValue))
                    {
                        text = reader.GetText();
                        s += text;
                        s += Environment.NewLine;
                        Console.Write(text + " ");
                    }
                }
                //Console.WriteLine();
                //Console.ReadKey();
            }
        }

        public static List<GenericInput> ReadPipesplz(string fileLocation, ILIMetaData howToReadThem)
        {
            List<GenericInput> allInputs = new List<GenericInput>();

            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileLocation, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                DocumentFormat.OpenXml.Spreadsheet.Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Row row in rows)
                {

                    var item = new GenericInput(howToReadThem);
                    List<string> values = new List<string>();
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        item.values.Add(GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i)));
                        //values.Add(GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i)));
                        //dataRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }
                    allInputs.Add(item);
                }

               

            }

            return allInputs;

        }


        public static System.Data.DataTable ReadAsDataTable(string fileName)
        {
            var dataTable = new System.Data.DataTable();
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(fileName, false))
            {
                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                DocumentFormat.OpenXml.Spreadsheet.Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                {
                    dataTable.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                }

                foreach (Row row in rows)
                {
                    var dataRow = dataTable.NewRow();
                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        dataRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                    }

                    dataTable.Rows.Add(dataRow);
                }

            }
            dataTable.Rows.RemoveAt(0);

            return dataTable;
        }

        private static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue?.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
    }

 




}


   

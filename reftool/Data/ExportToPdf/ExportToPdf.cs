using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using reftool_blazor_server.Data.Game;
using System;
using System.Collections.Generic;
using System.IO;

namespace reftool_blazor_server.Data
{
    /// <summary>
    /// Class for creating post-match report
    /// </summary>
    public static class ExportToPdf
    {
        static List<string> headers = new List<string>(new string[] { 
            "Player",
            "MINS",
            "PTS",
            "FG",
            "TP",
            "FT",
            "ORBS",
            "RBS",
            "AST",
            "STL",
            "BLK",
            "TO",
            "FLS"
        });

        static void DefineStyle(Document document)
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Verdana";

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Size = 9;

            style = document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }
        /// <summary>
        /// Main generate report method
        /// </summary>
        /// <param name="g">Game object</param>
        /// <returns>MemoryStream to download file</returns>
        public static MemoryStream GenerateReport(reftool_blazor_server.Data.Game.Game g)
        {
            Document document = new Document();
            document.Info.Title = "Report";

            Section section = document.AddSection();

            Paragraph paragraphDate = section.Headers.Primary.AddParagraph();
            paragraphDate.AddDateField("dd.MM.yyyy");
            paragraphDate.Format.Font.Size = 9;
            paragraphDate.Format.Alignment = ParagraphAlignment.Center;

            Paragraph paragraphFooter = section.Footers.Primary.AddParagraph("RefTool -- Paweł Szeląg 2021");
            paragraphFooter.Format.Font.Size = 9;
            paragraphFooter.Format.Alignment = ParagraphAlignment.Center;
            paragraphFooter.Format.Font.Color = Color.FromRgb(165, 165, 165);

            Paragraph homeTeamName = section.AddParagraph(g.GetHomeTeam().Name);
            homeTeamName.Format.Font.Bold = true;
            paragraphDate.Format.Font.Size = 14;
            paragraphDate.Format.Alignment = ParagraphAlignment.Center;
            var tableHome = section.AddTable();
            DefineStyle(document);
            tableHome.Style = "Table";
            tableHome.Borders.Width = 0.25;
            tableHome.Borders.Left.Width = 0.5;
            tableHome.Borders.Right.Width = 0.5;
            tableHome.Rows.LeftIndent = 0;            
            AddColumns(tableHome);
            AddHeaders(tableHome);
            AddTeam(tableHome, g.GetHomeTeam());
            section.AddParagraph();

            Paragraph awayTeamName = section.AddParagraph(g.GetAwayTeam().Name);
            awayTeamName.Format.Font.Bold = true;
            paragraphDate.Format.Font.Size = 14;
            paragraphDate.Format.Alignment = ParagraphAlignment.Center;
            var tableAway = section.AddTable();
            DefineStyle(document);
            tableAway.Style = "Table";
            tableAway.Borders.Width = 0.25;
            tableAway.Borders.Left.Width = 0.5;
            tableAway.Borders.Right.Width = 0.5;
            tableAway.Rows.LeftIndent = 0;
            AddColumns(tableAway);
            AddHeaders(tableAway);
            AddTeam(tableAway, g.GetAwayTeam());



            MemoryStream stream = new MemoryStream();
            DocumentRenderer renderer = new DocumentRenderer(document);
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(stream, false);
            return stream;

        }

        static void AddColumns(Table table)
        {
            Column column = table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("1.2cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("1.2cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("1.2cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
            column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Left;
        }

        static void AddHeaders(Table table)
        {
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;

            for (int i = 0; i < headers.Count; i++)
            {
                row.Cells[i].AddParagraph(headers[i]);
            }
        }

        static void AddTeam(Table table, Team team)
        {
            foreach(Player p in team.Players)
            {
                Row row = table.AddRow();
                row.HeadingFormat = false;
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Format.Font.Bold = false;
                row.Cells[0].AddParagraph(String.Format("#{0} {1} {2}", p.Number, p.Name, p.Surname));
                row.Cells[1].AddParagraph(p.Stats.TimeInMin().ToString());
                row.Cells[2].AddParagraph(p.Stats.Points.ToString());
                row.Cells[3].AddParagraph(String.Format("{0}/{1}", p.Stats.FGM, p.Stats.FGA));
                row.Cells[4].AddParagraph(String.Format("{0}/{1}", p.Stats.TPM, p.Stats.TPA));
                row.Cells[5].AddParagraph(String.Format("{0}/{1}", p.Stats.FTM, p.Stats.FTA));
                row.Cells[6].AddParagraph(p.Stats.ORebounds.ToString());
                row.Cells[7].AddParagraph(p.Stats.Rebounds.ToString());
                row.Cells[8].AddParagraph(p.Stats.Assists.ToString());
                row.Cells[9].AddParagraph(p.Stats.Steals.ToString());
                row.Cells[10].AddParagraph(p.Stats.Blocks.ToString());
                row.Cells[11].AddParagraph(p.Stats.Turnovers.ToString());
                row.Cells[12].AddParagraph(p.Stats.Fouls.ToString());
            }

            
            Row teamRow = table.AddRow();
            teamRow.HeadingFormat = false;
            teamRow.Format.Alignment = ParagraphAlignment.Center;
            teamRow.Cells[0].AddParagraph();
            teamRow.Cells[1].AddParagraph();
            Paragraph paragraph = teamRow.Cells[2].AddParagraph(team.Stats.Points.ToString());
            paragraph.Format.Font.Bold = true;
            teamRow.Cells[3].AddParagraph(String.Format("{0}% ({1}/{2})", Convert.ToDouble(team.Stats.FGM) / GetDivisor(team.Stats.FGA) * 100, team.Stats.FGM, team.Stats.FGA));
            teamRow.Cells[4].AddParagraph(String.Format("{0}% ({1}/{2})", Convert.ToDouble(team.Stats.TPM) / GetDivisor(team.Stats.TPA) * 100, team.Stats.TPM, team.Stats.TPA));
            teamRow.Cells[5].AddParagraph(String.Format("{0}% ({1}/{2})", Convert.ToDouble(team.Stats.FTM) / GetDivisor(team.Stats.FTA) * 100, team.Stats.FTM, team.Stats.FTA));
            teamRow.Cells[6].AddParagraph(team.Stats.ORebounds.ToString());
            teamRow.Cells[7].AddParagraph(team.Stats.Rebounds.ToString());
            teamRow.Cells[8].AddParagraph(team.Stats.Assists.ToString());
            teamRow.Cells[9].AddParagraph(team.Stats.Steals.ToString());
            teamRow.Cells[10].AddParagraph(team.Stats.Blocks.ToString());
            teamRow.Cells[11].AddParagraph(team.Stats.Turnovers.ToString());
            teamRow.Cells[12].AddParagraph(team.Stats.Fouls.ToString());


        }

        static double GetDivisor(int value)
        {
            if (value == 0)
                value = 1;

            return Convert.ToDouble(value);
        }



    }
}

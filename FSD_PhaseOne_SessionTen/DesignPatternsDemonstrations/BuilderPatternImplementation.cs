using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemonstrations
{
    /**
     *  It builds a complex object using simple object.
     *  And It follows step by step approach.
     * 
     */

    // Builder
    // Product
    // Concreate Builder
    // Directory

    // Product: Report Class
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine("Report Type : " + ReportType);
            Console.WriteLine("Report Header : " + ReportHeader);
            Console.WriteLine("Report Content : " + ReportContent);
            Console.WriteLine("Report Footer : " + ReportFooter);
        }
    }

    // Abstract Builder: ReportBuilder Class

    public abstract class ReportBuilder
    {
        public Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }

    // Concrete Builder Class: ExcelReport

    class ExcelReport : ReportBuilder
    {
       
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportContent = "Excel";
        }
    }

    // Concrete Builder Class: PDFReport

    class PDFReport: ReportBuilder
    {
       
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportContent = "PDF";
        }
    }

    // Create Director: ReportDirector Class

    class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
    class BuilderPatternImplementation
    {
        public static void Main(string[] args)
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            PDFReport pDFReport = new PDFReport();
            report = reportDirector.MakeReport(pDFReport);
            report.DisplayReport();

            Console.WriteLine("--------------------------------");

            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();

        }

    }
}

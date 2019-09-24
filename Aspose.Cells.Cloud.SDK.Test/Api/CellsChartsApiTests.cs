/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing CellsChartsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsChartsApiTests:CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi( clientId, clientSecret);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }
        
        /// <summary>
        /// Test CellsChartsDeleteWorksheetChartLegend
        /// </summary>
        [Test]
        public void CellsChartsDeleteWorksheetChartLegendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsDeleteWorksheetChartLegend(name, sheetName, chartIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsDeleteWorksheetChartTitle
        /// </summary>
        [Test]
        public void CellsChartsDeleteWorksheetChartTitleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsDeleteWorksheetChartTitle(name, sheetName, chartIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsDeleteWorksheetClearCharts
        /// </summary>
        [Test]
        public void CellsChartsDeleteWorksheetClearChartsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsDeleteWorksheetClearCharts(name, sheetName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsDeleteWorksheetDeleteChart
        /// </summary>
        [Test]
        public void CellsChartsDeleteWorksheetDeleteChartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsDeleteWorksheetDeleteChart(name, sheetName, chartIndex, folder);
            Assert.IsInstanceOf<ChartsResponse>(response, "response is ChartsResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsGetWorksheetChart
        /// </summary>
        [Test]
        public void CellsChartsGetWorksheetChartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartNumber = 0;
            string folder = TEMPFOLDER;
            string format = "png";
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsGetWorksheetChart(name, sheetName, chartNumber, format, folder);
            Assert.IsInstanceOf<System.IO.Stream>(response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test CellsChartsGetWorksheetChartLegend
        /// </summary>
        [Test]
        public void CellsChartsGetWorksheetChartLegendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsGetWorksheetChartLegend(name, sheetName, chartIndex, folder);
            Assert.IsInstanceOf<LegendResponse>(response, "response is LegendResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsChartsGetWorksheetChartTitle
        /// </summary>
        [Test]
        public void CellsChartsGetWorksheetChartTitleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET4;
            int? chartIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsGetWorksheetChartTitle(name, sheetName, chartIndex,  folder);
            Assert.IsInstanceOf<TitleResponse>(response, "response is TitleResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsChartsGetWorksheetCharts
        /// </summary>
        [Test]
        public void CellsChartsGetWorksheetChartsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsGetWorksheetCharts(name, sheetName, folder);
            Assert.IsInstanceOf<ChartsResponse>(response, "response is ChartsResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsChartsPostWorksheetChart
        /// </summary>
        [Test]
        public void CellsChartsPostWorksheetChartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            Chart chart = new Chart ();
            chart.AutoScaling = true;

            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsPostWorksheetChart(name, sheetName, chartIndex, chart, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);

        }

        /// <summary>
        /// Test CellsChartsPostWorksheetChartLegend
        /// </summary>
        [Test]
        public void CellsChartsPostWorksheetChartLegendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            Legend legend = new Legend();
            legend.Width = 10;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsPostWorksheetChartLegend(name, sheetName, chartIndex, legend, folder);
            Assert.IsInstanceOf<LegendResponse>(response, "response is LegendResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsPostWorksheetChartTitle
        /// </summary>
        [Test]
        public void CellsChartsPostWorksheetChartTitleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            Title title = new Title();
            title.Text = "Post title";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsPostWorksheetChartTitle(name, sheetName, chartIndex, title, folder);
            Assert.IsInstanceOf<TitleResponse>(response, "response is TitleResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsPutWorksheetAddChart
        /// </summary>
        [Test]
        public void CellsChartsPutWorksheetAddChartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET4;
            string chartType = "Pie";
            int? upperLeftRow = 5;
            int? upperLeftColumn = 5;
            int? lowerRightRow = 10;
            int? lowerRightColumn = 10;
            string area = "C7:D11";
            bool? isVertical = true;
            string categoryData = null;
            bool? isAutoGetSerialName = null;
            string title = null;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsPutWorksheetAddChart(name, sheetName, chartType, upperLeftRow, upperLeftColumn, lowerRightRow, lowerRightColumn, area, isVertical, categoryData, isAutoGetSerialName, title, folder);
            Assert.IsInstanceOf<ChartsResponse>(response, "response is ChartsResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsPutWorksheetChartLegend
        /// </summary>
        [Test]
        public void CellsChartsPutWorksheetChartLegendTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsPutWorksheetChartLegend(name, sheetName, chartIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsChartsPutWorksheetChartTitle
        /// </summary>
        [Test]
        public void CellsChartsPutWorksheetChartTitleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = MYDOC;
            string sheetName = SHEET3;
            int? chartIndex = 0;
            Title title = new Title();
            title.Text = "New title";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsChartsPutWorksheetChartTitle(name, sheetName, chartIndex, title, folder);
            Assert.IsInstanceOf<TitleResponse>(response, "response is TitleResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}

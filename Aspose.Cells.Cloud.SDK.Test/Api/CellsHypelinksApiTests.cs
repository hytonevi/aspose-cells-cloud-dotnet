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
    ///  Class for testing CellsHypelinksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsHypelinksApiTests : CellsBaseTest
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
        /// Test CellsHypelinksDeleteWorkSheetHyperlink
        /// </summary>
        [Test]
        public void CellsHypelinksDeleteWorkSheetHyperlinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? hyperlinkIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsHypelinksDeleteWorksheetHyperlink(name, sheetName, hyperlinkIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsHypelinksDeleteWorkSheetHyperlinks
        /// </summary>
        [Test]
        public void CellsHypelinksDeleteWorkSheetHyperlinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsHypelinksDeleteWorksheetHyperlinks(name, sheetName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsHypelinksGetWorkSheetHyperlink
        /// </summary>
        [Test]
        public void CellsHypelinksGetWorkSheetHyperlinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? hyperlinkIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsHypelinksGetWorksheetHyperlink(name, sheetName, hyperlinkIndex, folder);
            Assert.IsInstanceOf<HyperlinkResponse>(response, "response is HyperlinkResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsHypelinksGetWorkSheetHyperlinks
        /// </summary>
        [Test]
        public void CellsHypelinksGetWorkSheetHyperlinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsHypelinksGetWorksheetHyperlinks(name, sheetName, folder);
            Assert.IsInstanceOf<HyperlinksResponse>(response, "response is HyperlinksResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsHypelinksPostWorkSheetHyperlink
        /// </summary>
        [Test]
        public void CellsHypelinksPostWorkSheetHyperlinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? hyperlinkIndex = 0;
            Hyperlink hyperlink = new Hyperlink( );
            //new Link("http://wwww.aspose.com"),"http://www.aspose.com",new CellArea(2,2,1,1
            hyperlink.Address = "http://www.aspose.com";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsHypelinksPostWorksheetHyperlink(name, sheetName, hyperlinkIndex, hyperlink, folder);
            Assert.IsInstanceOf<HyperlinkResponse>(response, "response is HyperlinkResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsHypelinksPutWorkSheetHyperlink
        /// </summary>
        [Test]
        public void CellsHypelinksPutWorkSheetHyperlinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? firstRow = 1;
            int? firstColumn = 1;
            int? totalRows = 2;
            int? totalColumns = 3;
            string address = "http://wwww.aspose.com";
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsHypelinksPutWorksheetHyperlink(name, sheetName, firstRow, firstColumn, totalRows, totalColumns, address, folder);
            Assert.IsInstanceOf<HyperlinkResponse>(response, "response is HyperlinkResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}

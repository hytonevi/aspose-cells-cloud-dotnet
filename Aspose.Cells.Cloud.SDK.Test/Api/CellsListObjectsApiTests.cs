
namespace Aspose.Cells.Cloud.SDK.Test
{
    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    using System.Collections.Generic;

    /// <summary>
    ///  Class for testing CellsListObjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsListObjectsApiTests:CellsBaseTest
    {
        private CellsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CellsApi( clientId, clientSecret);;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test CellsListObjectsDeleteWorksheetListObject
        /// </summary>
        [Test]
        public void CellsListObjectsDeleteWorksheetListObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? listObjectIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsDeleteWorksheetListObject(name, sheetName, listObjectIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsListObjectsDeleteWorksheetListObjects
        /// </summary>
        [Test]
        public void CellsListObjectsDeleteWorksheetListObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsDeleteWorksheetListObjects(name, sheetName, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsGetWorksheetListObject
        /// </summary>
        [Test]
        public void CellsListObjectsGetWorksheetListObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? listobjectindex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsGetWorksheetListObject(name, sheetName, listobjectindex, folder);
            Assert.IsInstanceOf<ListObjectResponse>(response, "response is ListObjectResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsGetWorksheetListObjects
        /// </summary>
        [Test]
        public void CellsListObjectsGetWorksheetListObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsGetWorksheetListObjects(name, sheetName, folder);
            Assert.IsInstanceOf<ListObjectsResponse>(response, "response is ListObjectsResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsPostWorksheetListObject
        /// </summary>
        [Test]
        public void CellsListObjectsPostWorksheetListObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? listObjectIndex = 0;
            ListObject listObject = new ListObject();
            listObject.ShowHeaderRow = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObject(name, sheetName, listObjectIndex, listObject, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsPostWorksheetListObjectConvertToRange
        /// </summary>
        [Test]
        public void CellsListObjectsPostWorksheetListObjectConvertToRangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? listObjectIndex = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObjectConvertToRange(name, sheetName, listObjectIndex, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsPostWorksheetListObjectSortTable
        /// </summary>
        [Test]
        public void CellsListObjectsPostWorksheetListObjectSortTableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? listObjectIndex = 0;
            DataSorter dataSorter = new DataSorter();
            dataSorter.CaseSensitive = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObjectSortTable(name, sheetName, listObjectIndex, dataSorter, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable
        /// </summary>
        [Test]
        public void CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? listObjectIndex = 0;
            string destsheetName = "Sheet2";
            CreatePivotTableRequest request = new CreatePivotTableRequest ();
            //"testP", "=Sheet2!A1:E8","C1",true, new List<int?>() { 1 },new List<int?>() { 2},new List<int?>() { 3 }
            request.DestCellName = "C1";
            request.Name = "testp";
            request.PivotFieldColumns = new List<int?>() { 2 };
            request.PivotFieldData = new List<int?>() { 1 };
            request.PivotFieldRows = new List<int?>() { 0 };
            request.SourceData = "=Sheet2!A1:E8";
            request.UseSameSource = true;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsPostWorksheetListObjectSummarizeWithPivotTable(name, sheetName, listObjectIndex, destsheetName, request, folder);
            Assert.IsInstanceOf<CellsCloudResponse>(response, "response is CellsCloudResponse");
            Assert.AreEqual(response.Code, 200);
        }

        /// <summary>
        /// Test CellsListObjectsPutWorksheetListObject
        /// </summary>
        [Test]
        public void CellsListObjectsPutWorksheetListObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET7;
            int? startRow = 1;
            int? startColumn = 1;
            int? endRow = 6;
            int? endColumn = 6;
            string folder = TEMPFOLDER;
            bool? hasHeaders = null;
            UpdateDataFile(instance,folder, name);
            var response = instance.CellsListObjectsPutWorksheetListObject(name, sheetName, startRow, startColumn, endRow, endColumn, hasHeaders, null, folder);
            Assert.IsInstanceOf<ListObjectResponse>(response, "response is ListObjectResponse");
            Assert.AreEqual(response.Code, 200);
        }

    }

}

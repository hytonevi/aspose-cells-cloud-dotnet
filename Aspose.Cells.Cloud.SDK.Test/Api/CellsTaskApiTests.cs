namespace Aspose.Cells.Cloud.SDK.Test
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Aspose.Cells.Cloud.SDK.Api;
    using Aspose.Cells.Cloud.SDK.Model;
    /// <summary>
    ///  Class for testing CellsTaskApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsTaskApiTests:CellsBaseTest
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
        /// Test CellsTaskPostRunTask
        /// </summary>
        [Test]
        public void CellsTaskPostRunTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET6;
            string folder = TEMPFOLDER;
            UpdateDataFile(instance, name);

            TaskData taskData = new TaskData();
            taskData.Tasks = new List<TaskDescription>();
            TaskDescription task1 = new TaskDescription();
            task1.TaskType = "SplitWorkbook";

            SplitWorkbookTaskParameter param1 = new SplitWorkbookTaskParameter();
            param1.DestinationFileFormat = "xlsx";
            param1.DestinationFilePosition = new FileSource();
            param1.DestinationFilePosition.FilePath = folder;
            param1.DestinationFilePosition.FileSourceType = "CloudFileSystem";
            param1.SplitNameRule = "sheetname";
            param1.Workbook = new FileSource();
            param1.Workbook.FileSourceType = "CloudFileSystem";
            param1.Workbook.FilePath =  BOOK1;
            task1.TaskParameter = param1;
            taskData.Tasks.Add(task1);
            var response = instance.CellsTaskPostRunTask(taskData);
            Assert.IsInstanceOf<Object>(response, "response is System.IO.Stream");
        }
        
    }

}

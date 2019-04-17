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
    ///  Class for testing OAuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OAuthApiTests
    {
        private OAuthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OAuthApi("https://api.aspose.cloud");
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OAuthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OAuthApi
           Assert.IsInstanceOf(typeof(OAuthApi), instance, "instance is a OAuthApi");
        }

        
        /// <summary>
        /// Test OAuthPost
        /// </summary>
        [Test]
        public void OAuthPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string grantType = "client_credentials";
            string clientId = "xxxxxx-693E-xxx-xxx-xxxxxxxxx";
            string clientSecret = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            var response = instance.OAuthPost(grantType, clientId, clientSecret);
            Assert.IsInstanceOf<AccessTokenResponse>(response, "response is AccessTokenResponse");
            Assert.IsNotNull(response.AccessToken);
        }
        
    }

}

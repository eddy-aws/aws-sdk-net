/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.IdentityManagement.Endpoints;
using Amazon.IdentityManagement.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class IdentityManagementServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For region aws-cn-global with FIPS disabled and DualStack disabled")]
        public void For_region_awscnglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "aws-cn-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://iam.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For region aws-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://iam.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For region aws-iso-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsisoglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "aws-iso-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://iam.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For region aws-iso-b-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsisobglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "aws-iso-b-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://iam.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For region aws-us-gov-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsusgovglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "aws-us-gov-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://iam.us-gov.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IdentityManagement")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new IdentityManagementServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIdentityManagementServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}
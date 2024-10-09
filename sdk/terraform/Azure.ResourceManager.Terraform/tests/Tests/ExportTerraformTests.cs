// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Terraform.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Terraform.Tests.Tests
{
    [TestFixture]
    public class ExportTerraformTests : TerraformManagementTestBase
    {
        private ResourceGroupResource _resourceGroup;

        public ExportTerraformTests() : base(true)
        {
        }

        [SetUp]
        public async Task SetUp()
        {
            _resourceGroup = await CreateResourceGroup(DefaultSubscription, "exportTerraformRg", AzureLocation.WestUS);
        }

        [TearDown]
        public async Task TearDown()
        {
            await _resourceGroup.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        [RecordedTest]
        public async Task ExportTerraform()
        {
            string rgName = _resourceGroup.Data.Name;
            ArmOperation<ExportResult> exportResult = await DefaultSubscription.ExportTerraformAzureTerraformClientAsync(WaitUntil.Completed, new ExportResourceGroup(rgName));
            string hcl = exportResult.Value.Configuration;

            Assert.That(hcl, Does.Contain("azurerm_resource_group"));
            Assert.That(hcl, Does.Contain(rgName));
        }
    }
}

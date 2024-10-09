// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Terraform.Models;

namespace Azure.ResourceManager.Terraform.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableTerraformSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _azureTerraformClientClientDiagnostics;
        private AzureTerraformRestOperations _azureTerraformClientRestClient;
        private ClientDiagnostics _operationStatusesClientDiagnostics;
        private OperationStatusesRestOperations _operationStatusesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableTerraformSubscriptionResource"/> class for mocking. </summary>
        protected MockableTerraformSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableTerraformSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableTerraformSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AzureTerraformClientClientDiagnostics => _azureTerraformClientClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Terraform", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzureTerraformRestOperations AzureTerraformClientRestClient => _azureTerraformClientRestClient ??= new AzureTerraformRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics OperationStatusesClientDiagnostics => _operationStatusesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Terraform", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private OperationStatusesRestOperations OperationStatusesRestClient => _operationStatusesRestClient ??= new OperationStatusesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Exports the Terraform configuration of the specified resource(s).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureTerraform/exportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTerraform_ExportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exportParameter"> The export parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportParameter"/> is null. </exception>
        public virtual async Task<ArmOperation<ExportResult>> ExportTerraformAzureTerraformClientAsync(WaitUntil waitUntil, BaseExportModel exportParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(exportParameter, nameof(exportParameter));

            using var scope = AzureTerraformClientClientDiagnostics.CreateScope("MockableTerraformSubscriptionResource.ExportTerraformAzureTerraformClient");
            scope.Start();
            try
            {
                var response = await AzureTerraformClientRestClient.ExportTerraformAsync(Id.SubscriptionId, exportParameter, cancellationToken).ConfigureAwait(false);
                var operation = new TerraformArmOperation<ExportResult>(new ExportResultOperationSource(), AzureTerraformClientClientDiagnostics, Pipeline, AzureTerraformClientRestClient.CreateExportTerraformRequest(Id.SubscriptionId, exportParameter).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Exports the Terraform configuration of the specified resource(s).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureTerraform/exportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureTerraform_ExportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exportParameter"> The export parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportParameter"/> is null. </exception>
        public virtual ArmOperation<ExportResult> ExportTerraformAzureTerraformClient(WaitUntil waitUntil, BaseExportModel exportParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(exportParameter, nameof(exportParameter));

            using var scope = AzureTerraformClientClientDiagnostics.CreateScope("MockableTerraformSubscriptionResource.ExportTerraformAzureTerraformClient");
            scope.Start();
            try
            {
                var response = AzureTerraformClientRestClient.ExportTerraform(Id.SubscriptionId, exportParameter, cancellationToken);
                var operation = new TerraformArmOperation<ExportResult>(new ExportResultOperationSource(), AzureTerraformClientClientDiagnostics, Pipeline, AzureTerraformClientRestClient.CreateExportTerraformRequest(Id.SubscriptionId, exportParameter).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the status of a long running azure asynchronous operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureTerraform/operationStatuses/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationStatuses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<ArmOperation> GetOperationStatusAsync(WaitUntil waitUntil, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = OperationStatusesClientDiagnostics.CreateScope("MockableTerraformSubscriptionResource.GetOperationStatus");
            scope.Start();
            try
            {
                var response = await OperationStatusesRestClient.GetAsync(operationId, Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                var operation = new TerraformArmOperation(OperationStatusesClientDiagnostics, Pipeline, OperationStatusesRestClient.CreateGetRequest(operationId, Id.SubscriptionId).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the status of a long running azure asynchronous operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureTerraform/operationStatuses/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>OperationStatuses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="operationId"> The ID of an ongoing async operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual ArmOperation GetOperationStatus(WaitUntil waitUntil, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = OperationStatusesClientDiagnostics.CreateScope("MockableTerraformSubscriptionResource.GetOperationStatus");
            scope.Start();
            try
            {
                var response = OperationStatusesRestClient.Get(operationId, Id.SubscriptionId, cancellationToken);
                var operation = new TerraformArmOperation(OperationStatusesClientDiagnostics, Pipeline, OperationStatusesRestClient.CreateGetRequest(operationId, Id.SubscriptionId).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

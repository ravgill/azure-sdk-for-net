// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="TagDescriptionContractResource" /> and their operations.
    /// Each <see cref="TagDescriptionContractResource" /> in the collection will belong to the same instance of <see cref="ApiContractResource" />.
    /// To get a <see cref="TagDescriptionContractCollection" /> instance call the GetTagDescriptionContracts method from an instance of <see cref="ApiContractResource" />.
    /// </summary>
    public partial class TagDescriptionContractCollection : ArmCollection, IEnumerable<TagDescriptionContractResource>, IAsyncEnumerable<TagDescriptionContractResource>
    {
        private readonly ClientDiagnostics _tagDescriptionContractApiTagDescriptionClientDiagnostics;
        private readonly ApiTagDescriptionRestOperations _tagDescriptionContractApiTagDescriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="TagDescriptionContractCollection"/> class for mocking. </summary>
        protected TagDescriptionContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TagDescriptionContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TagDescriptionContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tagDescriptionContractApiTagDescriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", TagDescriptionContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TagDescriptionContractResource.ResourceType, out string tagDescriptionContractApiTagDescriptionApiVersion);
            _tagDescriptionContractApiTagDescriptionRestClient = new ApiTagDescriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tagDescriptionContractApiTagDescriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiContractResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiContractResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create/Update tag description in scope of the Api.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}
        /// Operation Id: ApiTagDescription_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<TagDescriptionContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tagDescriptionId, TagDescriptionContractCreateOrUpdateContent content, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tagDescriptionContractApiTagDescriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<TagDescriptionContractResource>(Response.FromValue(new TagDescriptionContractResource(Client, response), response.GetRawResponse()));
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
        /// Create/Update tag description in scope of the Api.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}
        /// Operation Id: ApiTagDescription_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<TagDescriptionContractResource> CreateOrUpdate(WaitUntil waitUntil, string tagDescriptionId, TagDescriptionContractCreateOrUpdateContent content, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tagDescriptionContractApiTagDescriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<TagDescriptionContractResource>(Response.FromValue(new TagDescriptionContractResource(Client, response), response.GetRawResponse()));
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
        /// Get Tag description in scope of API
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}
        /// Operation Id: ApiTagDescription_Get
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual async Task<Response<TagDescriptionContractResource>> GetAsync(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _tagDescriptionContractApiTagDescriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TagDescriptionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Tag description in scope of API
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}
        /// Operation Id: ApiTagDescription_Get
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual Response<TagDescriptionContractResource> Get(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.Get");
            scope.Start();
            try
            {
                var response = _tagDescriptionContractApiTagDescriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TagDescriptionContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Tags descriptions in scope of API. Model similar to swagger - tagDescription is defined on API level but tag may be assigned to the Operations
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions
        /// Operation Id: ApiTagDescription_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TagDescriptionContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TagDescriptionContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TagDescriptionContractResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tagDescriptionContractApiTagDescriptionRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TagDescriptionContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TagDescriptionContractResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tagDescriptionContractApiTagDescriptionRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TagDescriptionContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all Tags descriptions in scope of API. Model similar to swagger - tagDescription is defined on API level but tag may be assigned to the Operations
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions
        /// Operation Id: ApiTagDescription_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TagDescriptionContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TagDescriptionContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<TagDescriptionContractResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tagDescriptionContractApiTagDescriptionRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TagDescriptionContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TagDescriptionContractResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tagDescriptionContractApiTagDescriptionRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TagDescriptionContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}
        /// Operation Id: ApiTagDescription_Get
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tagDescriptionContractApiTagDescriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/tagDescriptions/{tagDescriptionId}
        /// Operation Id: ApiTagDescription_Get
        /// </summary>
        /// <param name="tagDescriptionId"> Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tagDescriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tagDescriptionId"/> is null. </exception>
        public virtual Response<bool> Exists(string tagDescriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tagDescriptionId, nameof(tagDescriptionId));

            using var scope = _tagDescriptionContractApiTagDescriptionClientDiagnostics.CreateScope("TagDescriptionContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _tagDescriptionContractApiTagDescriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tagDescriptionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TagDescriptionContractResource> IEnumerable<TagDescriptionContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TagDescriptionContractResource> IAsyncEnumerable<TagDescriptionContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

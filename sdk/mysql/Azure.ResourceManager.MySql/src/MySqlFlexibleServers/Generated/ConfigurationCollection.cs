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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    /// <summary>
    /// A class representing a collection of <see cref="ConfigurationResource" /> and their operations.
    /// Each <see cref="ConfigurationResource" /> in the collection will belong to the same instance of <see cref="ServerResource" />.
    /// To get a <see cref="ConfigurationCollection" /> instance call the GetConfigurations method from an instance of <see cref="ServerResource" />.
    /// </summary>
    public partial class ConfigurationCollection : ArmCollection, IEnumerable<ConfigurationResource>, IAsyncEnumerable<ConfigurationResource>
    {
        private readonly ClientDiagnostics _configurationClientDiagnostics;
        private readonly ConfigurationsRestOperations _configurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationCollection"/> class for mocking. </summary>
        protected ConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _configurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql.FlexibleServers", ConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConfigurationResource.ResourceType, out string configurationApiVersion);
            _configurationRestClient = new ConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, configurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<ConfigurationResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _configurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a configuration of server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<ConfigurationResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _configurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the configurations in a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations
        /// Operation Id: Configurations_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ConfigurationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConfigurationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all the configurations in a given server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations
        /// Operation Id: Configurations_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ConfigurationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConfigurationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConfigurationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _configurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/flexibleServers/{serverName}/configurations/{configurationName}
        /// Operation Id: Configurations_Get
        /// </summary>
        /// <param name="configurationName"> The name of the server configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _configurationClientDiagnostics.CreateScope("ConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _configurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConfigurationResource> IEnumerable<ConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConfigurationResource> IAsyncEnumerable<ConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

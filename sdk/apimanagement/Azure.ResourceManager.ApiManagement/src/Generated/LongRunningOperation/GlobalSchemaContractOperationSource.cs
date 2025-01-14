// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    internal class GlobalSchemaContractOperationSource : IOperationSource<GlobalSchemaContractResource>
    {
        private readonly ArmClient _client;

        internal GlobalSchemaContractOperationSource(ArmClient client)
        {
            _client = client;
        }

        GlobalSchemaContractResource IOperationSource<GlobalSchemaContractResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GlobalSchemaContractData.DeserializeGlobalSchemaContractData(document.RootElement);
            return new GlobalSchemaContractResource(_client, data);
        }

        async ValueTask<GlobalSchemaContractResource> IOperationSource<GlobalSchemaContractResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GlobalSchemaContractData.DeserializeGlobalSchemaContractData(document.RootElement);
            return new GlobalSchemaContractResource(_client, data);
        }
    }
}

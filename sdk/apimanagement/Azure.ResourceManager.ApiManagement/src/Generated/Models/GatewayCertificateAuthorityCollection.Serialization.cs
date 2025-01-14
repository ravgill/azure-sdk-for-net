// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class GatewayCertificateAuthorityCollection
    {
        internal static GatewayCertificateAuthorityCollection DeserializeGatewayCertificateAuthorityCollection(JsonElement element)
        {
            Optional<IReadOnlyList<GatewayCertificateAuthorityContractData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GatewayCertificateAuthorityContractData> array = new List<GatewayCertificateAuthorityContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GatewayCertificateAuthorityContractData.DeserializeGatewayCertificateAuthorityContractData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayCertificateAuthorityCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}

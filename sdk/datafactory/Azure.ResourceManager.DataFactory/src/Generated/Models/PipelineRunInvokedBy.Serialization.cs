// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PipelineRunInvokedBy
    {
        internal static PipelineRunInvokedBy DeserializePipelineRunInvokedBy(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> invokedByType = default;
            Optional<string> pipelineName = default;
            Optional<string> pipelineRunId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invokedByType"))
                {
                    invokedByType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineName"))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"))
                {
                    pipelineRunId = property.Value.GetString();
                    continue;
                }
            }
            return new PipelineRunInvokedBy(name.Value, id.Value, invokedByType.Value, pipelineName.Value, pipelineRunId.Value);
        }
    }
}

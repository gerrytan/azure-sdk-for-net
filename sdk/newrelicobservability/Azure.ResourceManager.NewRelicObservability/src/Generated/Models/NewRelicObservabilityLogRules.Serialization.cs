// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityLogRules : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityLogRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityLogRules>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NewRelicObservabilityLogRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteStringValue(SendAadLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteStringValue(SendSubscriptionLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs"u8);
                writer.WriteStringValue(SendActivityLogs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        NewRelicObservabilityLogRules IJsonModel<NewRelicObservabilityLogRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityLogRules(document.RootElement, options);
        }

        internal static NewRelicObservabilityLogRules DeserializeNewRelicObservabilityLogRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NewRelicObservabilitySendAadLogsStatus? sendAadLogs = default;
            NewRelicObservabilitySendSubscriptionLogsStatus? sendSubscriptionLogs = default;
            NewRelicObservabilitySendActivityLogsStatus? sendActivityLogs = default;
            IList<NewRelicObservabilityFilteringTag> filteringTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = new NewRelicObservabilitySendAadLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = new NewRelicObservabilitySendSubscriptionLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendActivityLogs = new NewRelicObservabilitySendActivityLogsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewRelicObservabilityFilteringTag> array = new List<NewRelicObservabilityFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicObservabilityFilteringTag.DeserializeNewRelicObservabilityFilteringTag(item, options));
                    }
                    filteringTags = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NewRelicObservabilityLogRules(sendAadLogs, sendSubscriptionLogs, sendActivityLogs, filteringTags ?? new ChangeTrackingList<NewRelicObservabilityFilteringTag>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SendAadLogs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sendAadLogs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SendAadLogs))
                {
                    builder.Append("  sendAadLogs: ");
                    builder.AppendLine($"'{SendAadLogs.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SendSubscriptionLogs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sendSubscriptionLogs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SendSubscriptionLogs))
                {
                    builder.Append("  sendSubscriptionLogs: ");
                    builder.AppendLine($"'{SendSubscriptionLogs.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SendActivityLogs), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sendActivityLogs: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SendActivityLogs))
                {
                    builder.Append("  sendActivityLogs: ");
                    builder.AppendLine($"'{SendActivityLogs.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FilteringTags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  filteringTags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(FilteringTags))
                {
                    if (FilteringTags.Any())
                    {
                        builder.Append("  filteringTags: ");
                        builder.AppendLine("[");
                        foreach (var item in FilteringTags)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  filteringTags: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NewRelicObservabilityLogRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support writing '{options.Format}' format.");
            }
        }

        NewRelicObservabilityLogRules IPersistableModel<NewRelicObservabilityLogRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NewRelicObservabilityLogRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNewRelicObservabilityLogRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NewRelicObservabilityLogRules)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NewRelicObservabilityLogRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

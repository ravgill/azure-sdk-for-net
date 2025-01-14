// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactEnvelopeSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupAssociationAssignedCode))
            {
                writer.WritePropertyName("groupAssociationAssignedCode");
                writer.WriteStringValue(GroupAssociationAssignedCode);
            }
            if (Optional.IsDefined(CommunicationAgreementId))
            {
                writer.WritePropertyName("communicationAgreementId");
                writer.WriteStringValue(CommunicationAgreementId);
            }
            writer.WritePropertyName("applyDelimiterStringAdvice");
            writer.WriteBooleanValue(ApplyDelimiterStringAdvice);
            writer.WritePropertyName("createGroupingSegments");
            writer.WriteBooleanValue(CreateGroupingSegments);
            writer.WritePropertyName("enableDefaultGroupHeaders");
            writer.WriteBooleanValue(EnableDefaultGroupHeaders);
            if (Optional.IsDefined(RecipientReferencePasswordValue))
            {
                writer.WritePropertyName("recipientReferencePasswordValue");
                writer.WriteStringValue(RecipientReferencePasswordValue);
            }
            if (Optional.IsDefined(RecipientReferencePasswordQualifier))
            {
                writer.WritePropertyName("recipientReferencePasswordQualifier");
                writer.WriteStringValue(RecipientReferencePasswordQualifier);
            }
            if (Optional.IsDefined(ApplicationReferenceId))
            {
                writer.WritePropertyName("applicationReferenceId");
                writer.WriteStringValue(ApplicationReferenceId);
            }
            if (Optional.IsDefined(ProcessingPriorityCode))
            {
                writer.WritePropertyName("processingPriorityCode");
                writer.WriteStringValue(ProcessingPriorityCode);
            }
            writer.WritePropertyName("interchangeControlNumberLowerBound");
            writer.WriteNumberValue(InterchangeControlNumberLowerBound);
            writer.WritePropertyName("interchangeControlNumberUpperBound");
            writer.WriteNumberValue(InterchangeControlNumberUpperBound);
            writer.WritePropertyName("rolloverInterchangeControlNumber");
            writer.WriteBooleanValue(RolloverInterchangeControlNumber);
            if (Optional.IsDefined(InterchangeControlNumberPrefix))
            {
                writer.WritePropertyName("interchangeControlNumberPrefix");
                writer.WriteStringValue(InterchangeControlNumberPrefix);
            }
            if (Optional.IsDefined(InterchangeControlNumberSuffix))
            {
                writer.WritePropertyName("interchangeControlNumberSuffix");
                writer.WriteStringValue(InterchangeControlNumberSuffix);
            }
            if (Optional.IsDefined(SenderReverseRoutingAddress))
            {
                writer.WritePropertyName("senderReverseRoutingAddress");
                writer.WriteStringValue(SenderReverseRoutingAddress);
            }
            if (Optional.IsDefined(ReceiverReverseRoutingAddress))
            {
                writer.WritePropertyName("receiverReverseRoutingAddress");
                writer.WriteStringValue(ReceiverReverseRoutingAddress);
            }
            if (Optional.IsDefined(FunctionalGroupId))
            {
                writer.WritePropertyName("functionalGroupId");
                writer.WriteStringValue(FunctionalGroupId);
            }
            if (Optional.IsDefined(GroupControllingAgencyCode))
            {
                writer.WritePropertyName("groupControllingAgencyCode");
                writer.WriteStringValue(GroupControllingAgencyCode);
            }
            if (Optional.IsDefined(GroupMessageVersion))
            {
                writer.WritePropertyName("groupMessageVersion");
                writer.WriteStringValue(GroupMessageVersion);
            }
            if (Optional.IsDefined(GroupMessageRelease))
            {
                writer.WritePropertyName("groupMessageRelease");
                writer.WriteStringValue(GroupMessageRelease);
            }
            writer.WritePropertyName("groupControlNumberLowerBound");
            writer.WriteNumberValue(GroupControlNumberLowerBound);
            writer.WritePropertyName("groupControlNumberUpperBound");
            writer.WriteNumberValue(GroupControlNumberUpperBound);
            writer.WritePropertyName("rolloverGroupControlNumber");
            writer.WriteBooleanValue(RolloverGroupControlNumber);
            if (Optional.IsDefined(GroupControlNumberPrefix))
            {
                writer.WritePropertyName("groupControlNumberPrefix");
                writer.WriteStringValue(GroupControlNumberPrefix);
            }
            if (Optional.IsDefined(GroupControlNumberSuffix))
            {
                writer.WritePropertyName("groupControlNumberSuffix");
                writer.WriteStringValue(GroupControlNumberSuffix);
            }
            if (Optional.IsDefined(GroupApplicationReceiverQualifier))
            {
                writer.WritePropertyName("groupApplicationReceiverQualifier");
                writer.WriteStringValue(GroupApplicationReceiverQualifier);
            }
            if (Optional.IsDefined(GroupApplicationReceiverId))
            {
                writer.WritePropertyName("groupApplicationReceiverId");
                writer.WriteStringValue(GroupApplicationReceiverId);
            }
            if (Optional.IsDefined(GroupApplicationSenderQualifier))
            {
                writer.WritePropertyName("groupApplicationSenderQualifier");
                writer.WriteStringValue(GroupApplicationSenderQualifier);
            }
            if (Optional.IsDefined(GroupApplicationSenderId))
            {
                writer.WritePropertyName("groupApplicationSenderId");
                writer.WriteStringValue(GroupApplicationSenderId);
            }
            if (Optional.IsDefined(GroupApplicationPassword))
            {
                writer.WritePropertyName("groupApplicationPassword");
                writer.WriteStringValue(GroupApplicationPassword);
            }
            writer.WritePropertyName("overwriteExistingTransactionSetControlNumber");
            writer.WriteBooleanValue(OverwriteExistingTransactionSetControlNumber);
            if (Optional.IsDefined(TransactionSetControlNumberPrefix))
            {
                writer.WritePropertyName("transactionSetControlNumberPrefix");
                writer.WriteStringValue(TransactionSetControlNumberPrefix);
            }
            if (Optional.IsDefined(TransactionSetControlNumberSuffix))
            {
                writer.WritePropertyName("transactionSetControlNumberSuffix");
                writer.WriteStringValue(TransactionSetControlNumberSuffix);
            }
            writer.WritePropertyName("transactionSetControlNumberLowerBound");
            writer.WriteNumberValue(TransactionSetControlNumberLowerBound);
            writer.WritePropertyName("transactionSetControlNumberUpperBound");
            writer.WriteNumberValue(TransactionSetControlNumberUpperBound);
            writer.WritePropertyName("rolloverTransactionSetControlNumber");
            writer.WriteBooleanValue(RolloverTransactionSetControlNumber);
            writer.WritePropertyName("isTestInterchange");
            writer.WriteBooleanValue(IsTestInterchange);
            if (Optional.IsDefined(SenderInternalIdentification))
            {
                writer.WritePropertyName("senderInternalIdentification");
                writer.WriteStringValue(SenderInternalIdentification);
            }
            if (Optional.IsDefined(SenderInternalSubIdentification))
            {
                writer.WritePropertyName("senderInternalSubIdentification");
                writer.WriteStringValue(SenderInternalSubIdentification);
            }
            if (Optional.IsDefined(ReceiverInternalIdentification))
            {
                writer.WritePropertyName("receiverInternalIdentification");
                writer.WriteStringValue(ReceiverInternalIdentification);
            }
            if (Optional.IsDefined(ReceiverInternalSubIdentification))
            {
                writer.WritePropertyName("receiverInternalSubIdentification");
                writer.WriteStringValue(ReceiverInternalSubIdentification);
            }
            writer.WriteEndObject();
        }

        internal static EdifactEnvelopeSettings DeserializeEdifactEnvelopeSettings(JsonElement element)
        {
            Optional<string> groupAssociationAssignedCode = default;
            Optional<string> communicationAgreementId = default;
            bool applyDelimiterStringAdvice = default;
            bool createGroupingSegments = default;
            bool enableDefaultGroupHeaders = default;
            Optional<string> recipientReferencePasswordValue = default;
            Optional<string> recipientReferencePasswordQualifier = default;
            Optional<string> applicationReferenceId = default;
            Optional<string> processingPriorityCode = default;
            long interchangeControlNumberLowerBound = default;
            long interchangeControlNumberUpperBound = default;
            bool rolloverInterchangeControlNumber = default;
            Optional<string> interchangeControlNumberPrefix = default;
            Optional<string> interchangeControlNumberSuffix = default;
            Optional<string> senderReverseRoutingAddress = default;
            Optional<string> receiverReverseRoutingAddress = default;
            Optional<string> functionalGroupId = default;
            Optional<string> groupControllingAgencyCode = default;
            Optional<string> groupMessageVersion = default;
            Optional<string> groupMessageRelease = default;
            long groupControlNumberLowerBound = default;
            long groupControlNumberUpperBound = default;
            bool rolloverGroupControlNumber = default;
            Optional<string> groupControlNumberPrefix = default;
            Optional<string> groupControlNumberSuffix = default;
            Optional<string> groupApplicationReceiverQualifier = default;
            Optional<string> groupApplicationReceiverId = default;
            Optional<string> groupApplicationSenderQualifier = default;
            Optional<string> groupApplicationSenderId = default;
            Optional<string> groupApplicationPassword = default;
            bool overwriteExistingTransactionSetControlNumber = default;
            Optional<string> transactionSetControlNumberPrefix = default;
            Optional<string> transactionSetControlNumberSuffix = default;
            long transactionSetControlNumberLowerBound = default;
            long transactionSetControlNumberUpperBound = default;
            bool rolloverTransactionSetControlNumber = default;
            bool isTestInterchange = default;
            Optional<string> senderInternalIdentification = default;
            Optional<string> senderInternalSubIdentification = default;
            Optional<string> receiverInternalIdentification = default;
            Optional<string> receiverInternalSubIdentification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupAssociationAssignedCode"))
                {
                    groupAssociationAssignedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationAgreementId"))
                {
                    communicationAgreementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applyDelimiterStringAdvice"))
                {
                    applyDelimiterStringAdvice = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createGroupingSegments"))
                {
                    createGroupingSegments = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableDefaultGroupHeaders"))
                {
                    enableDefaultGroupHeaders = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recipientReferencePasswordValue"))
                {
                    recipientReferencePasswordValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recipientReferencePasswordQualifier"))
                {
                    recipientReferencePasswordQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationReferenceId"))
                {
                    applicationReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processingPriorityCode"))
                {
                    processingPriorityCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberLowerBound"))
                {
                    interchangeControlNumberLowerBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberUpperBound"))
                {
                    interchangeControlNumberUpperBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rolloverInterchangeControlNumber"))
                {
                    rolloverInterchangeControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberPrefix"))
                {
                    interchangeControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interchangeControlNumberSuffix"))
                {
                    interchangeControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderReverseRoutingAddress"))
                {
                    senderReverseRoutingAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverReverseRoutingAddress"))
                {
                    receiverReverseRoutingAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("functionalGroupId"))
                {
                    functionalGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControllingAgencyCode"))
                {
                    groupControllingAgencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupMessageVersion"))
                {
                    groupMessageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupMessageRelease"))
                {
                    groupMessageRelease = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControlNumberLowerBound"))
                {
                    groupControlNumberLowerBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("groupControlNumberUpperBound"))
                {
                    groupControlNumberUpperBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rolloverGroupControlNumber"))
                {
                    rolloverGroupControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("groupControlNumberPrefix"))
                {
                    groupControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupControlNumberSuffix"))
                {
                    groupControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationReceiverQualifier"))
                {
                    groupApplicationReceiverQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationReceiverId"))
                {
                    groupApplicationReceiverId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationSenderQualifier"))
                {
                    groupApplicationSenderQualifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationSenderId"))
                {
                    groupApplicationSenderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupApplicationPassword"))
                {
                    groupApplicationPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overwriteExistingTransactionSetControlNumber"))
                {
                    overwriteExistingTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberPrefix"))
                {
                    transactionSetControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberSuffix"))
                {
                    transactionSetControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberLowerBound"))
                {
                    transactionSetControlNumberLowerBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionSetControlNumberUpperBound"))
                {
                    transactionSetControlNumberUpperBound = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("rolloverTransactionSetControlNumber"))
                {
                    rolloverTransactionSetControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isTestInterchange"))
                {
                    isTestInterchange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("senderInternalIdentification"))
                {
                    senderInternalIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderInternalSubIdentification"))
                {
                    senderInternalSubIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverInternalIdentification"))
                {
                    receiverInternalIdentification = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receiverInternalSubIdentification"))
                {
                    receiverInternalSubIdentification = property.Value.GetString();
                    continue;
                }
            }
            return new EdifactEnvelopeSettings(groupAssociationAssignedCode.Value, communicationAgreementId.Value, applyDelimiterStringAdvice, createGroupingSegments, enableDefaultGroupHeaders, recipientReferencePasswordValue.Value, recipientReferencePasswordQualifier.Value, applicationReferenceId.Value, processingPriorityCode.Value, interchangeControlNumberLowerBound, interchangeControlNumberUpperBound, rolloverInterchangeControlNumber, interchangeControlNumberPrefix.Value, interchangeControlNumberSuffix.Value, senderReverseRoutingAddress.Value, receiverReverseRoutingAddress.Value, functionalGroupId.Value, groupControllingAgencyCode.Value, groupMessageVersion.Value, groupMessageRelease.Value, groupControlNumberLowerBound, groupControlNumberUpperBound, rolloverGroupControlNumber, groupControlNumberPrefix.Value, groupControlNumberSuffix.Value, groupApplicationReceiverQualifier.Value, groupApplicationReceiverId.Value, groupApplicationSenderQualifier.Value, groupApplicationSenderId.Value, groupApplicationPassword.Value, overwriteExistingTransactionSetControlNumber, transactionSetControlNumberPrefix.Value, transactionSetControlNumberSuffix.Value, transactionSetControlNumberLowerBound, transactionSetControlNumberUpperBound, rolloverTransactionSetControlNumber, isTestInterchange, senderInternalIdentification.Value, senderInternalSubIdentification.Value, receiverInternalIdentification.Value, receiverInternalSubIdentification.Value);
        }
    }
}

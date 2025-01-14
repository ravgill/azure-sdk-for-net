// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class ServerCallingModelFactory
    {
        /// <summary> Initializes a new instance of TransferCallToParticipantResult. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallingServer.TransferCallToParticipantResult"/> instance for mocking. </returns>
        public static TransferCallToParticipantResult TransferCallToParticipantResult(string operationContext = null)
        {
            return new TransferCallToParticipantResult(operationContext);
        }

        /// <summary> Initializes a new instance of RemoveParticipantsResult. </summary>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallingServer.RemoveParticipantsResult"/> instance for mocking. </returns>
        public static RemoveParticipantsResult RemoveParticipantsResult(string operationContext = null)
        {
            return new RemoveParticipantsResult(operationContext);
        }

        /// <summary> Initializes a new instance of RecordingStatusResult. </summary>
        /// <param name="recordingId"></param>
        /// <param name="recordingStatus"></param>
        /// <returns> A new <see cref="CallingServer.RecordingStatusResult"/> instance for mocking. </returns>
        public static RecordingStatusResult RecordingStatusResult(string recordingId = null, RecordingStatus? recordingStatus = null)
        {
            return new RecordingStatusResult(recordingId, recordingStatus);
        }
    }
}

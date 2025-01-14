// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The properties of cluster. </summary>
    public partial class ClusterGetProperties
    {
        /// <summary> Initializes a new instance of ClusterGetProperties. </summary>
        /// <param name="clusterDefinition"> The cluster definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterDefinition"/> is null. </exception>
        internal ClusterGetProperties(ClusterDefinition clusterDefinition)
        {
            if (clusterDefinition == null)
            {
                throw new ArgumentNullException(nameof(clusterDefinition));
            }

            ClusterDefinition = clusterDefinition;
            Errors = new ChangeTrackingList<Errors>();
            ConnectivityEndpoints = new ChangeTrackingList<ConnectivityEndpoint>();
            PrivateLinkConfigurations = new ChangeTrackingList<PrivateLinkConfiguration>();
            PrivateEndpointConnections = new ChangeTrackingList<HDInsightPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ClusterGetProperties. </summary>
        /// <param name="clusterVersion"> The version of the cluster. </param>
        /// <param name="clusterHdpVersion"> The hdp version of the cluster. </param>
        /// <param name="osType"> The type of operating system. </param>
        /// <param name="tier"> The cluster tier. </param>
        /// <param name="clusterId"> The cluster id. </param>
        /// <param name="clusterDefinition"> The cluster definition. </param>
        /// <param name="kafkaRestProperties"> The cluster kafka rest proxy configuration. </param>
        /// <param name="securityProfile"> The security profile. </param>
        /// <param name="computeProfile"> The compute profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="createdDate"> The date on which the cluster was created. </param>
        /// <param name="clusterState"> The state of the cluster. </param>
        /// <param name="quotaInfo"> The quota information. </param>
        /// <param name="errors"> The list of errors. </param>
        /// <param name="connectivityEndpoints"> The list of connectivity endpoints. </param>
        /// <param name="diskEncryptionProperties"> The disk encryption properties. </param>
        /// <param name="encryptionInTransitProperties"> The encryption-in-transit properties. </param>
        /// <param name="storageProfile"> The storage profile. </param>
        /// <param name="minSupportedTlsVersion"> The minimal supported tls version. </param>
        /// <param name="excludedServicesConfig"> The excluded services config. </param>
        /// <param name="networkProperties"> The network properties. </param>
        /// <param name="computeIsolationProperties"> The compute isolation properties. </param>
        /// <param name="privateLinkConfigurations"> The private link configurations. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections. </param>
        internal ClusterGetProperties(string clusterVersion, string clusterHdpVersion, OSType? osType, Tier? tier, string clusterId, ClusterDefinition clusterDefinition, KafkaRestProperties kafkaRestProperties, SecurityProfile securityProfile, ComputeProfile computeProfile, HDInsightClusterProvisioningState? provisioningState, string createdDate, string clusterState, QuotaInfo quotaInfo, IReadOnlyList<Errors> errors, IReadOnlyList<ConnectivityEndpoint> connectivityEndpoints, DiskEncryptionProperties diskEncryptionProperties, EncryptionInTransitProperties encryptionInTransitProperties, StorageProfile storageProfile, string minSupportedTlsVersion, ExcludedServicesConfig excludedServicesConfig, NetworkProperties networkProperties, ComputeIsolationProperties computeIsolationProperties, IReadOnlyList<PrivateLinkConfiguration> privateLinkConfigurations, IReadOnlyList<HDInsightPrivateEndpointConnectionData> privateEndpointConnections)
        {
            ClusterVersion = clusterVersion;
            ClusterHdpVersion = clusterHdpVersion;
            OSType = osType;
            Tier = tier;
            ClusterId = clusterId;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            ProvisioningState = provisioningState;
            CreatedDate = createdDate;
            ClusterState = clusterState;
            QuotaInfo = quotaInfo;
            Errors = errors;
            ConnectivityEndpoints = connectivityEndpoints;
            DiskEncryptionProperties = diskEncryptionProperties;
            EncryptionInTransitProperties = encryptionInTransitProperties;
            StorageProfile = storageProfile;
            MinSupportedTlsVersion = minSupportedTlsVersion;
            ExcludedServicesConfig = excludedServicesConfig;
            NetworkProperties = networkProperties;
            ComputeIsolationProperties = computeIsolationProperties;
            PrivateLinkConfigurations = privateLinkConfigurations;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> The version of the cluster. </summary>
        public string ClusterVersion { get; }
        /// <summary> The hdp version of the cluster. </summary>
        public string ClusterHdpVersion { get; }
        /// <summary> The type of operating system. </summary>
        public OSType? OSType { get; }
        /// <summary> The cluster tier. </summary>
        public Tier? Tier { get; }
        /// <summary> The cluster id. </summary>
        public string ClusterId { get; }
        /// <summary> The cluster definition. </summary>
        public ClusterDefinition ClusterDefinition { get; }
        /// <summary> The cluster kafka rest proxy configuration. </summary>
        public KafkaRestProperties KafkaRestProperties { get; }
        /// <summary> The security profile. </summary>
        public SecurityProfile SecurityProfile { get; }
        /// <summary> The compute profile. </summary>
        internal ComputeProfile ComputeProfile { get; }
        /// <summary> The list of roles in the cluster. </summary>
        public IList<Role> ComputeRoles
        {
            get => ComputeProfile?.Roles;
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public HDInsightClusterProvisioningState? ProvisioningState { get; }
        /// <summary> The date on which the cluster was created. </summary>
        public string CreatedDate { get; }
        /// <summary> The state of the cluster. </summary>
        public string ClusterState { get; }
        /// <summary> The quota information. </summary>
        internal QuotaInfo QuotaInfo { get; }
        /// <summary> The cores used by the cluster. </summary>
        public int? QuotaInfoCoresUsed
        {
            get => QuotaInfo?.CoresUsed;
        }

        /// <summary> The list of errors. </summary>
        public IReadOnlyList<Errors> Errors { get; }
        /// <summary> The list of connectivity endpoints. </summary>
        public IReadOnlyList<ConnectivityEndpoint> ConnectivityEndpoints { get; }
        /// <summary> The disk encryption properties. </summary>
        public DiskEncryptionProperties DiskEncryptionProperties { get; }
        /// <summary> The encryption-in-transit properties. </summary>
        internal EncryptionInTransitProperties EncryptionInTransitProperties { get; }
        /// <summary> Indicates whether or not inter cluster node communication is encrypted in transit. </summary>
        public bool? IsEncryptionInTransitEnabled
        {
            get => EncryptionInTransitProperties?.IsEncryptionInTransitEnabled;
        }

        /// <summary> The storage profile. </summary>
        internal StorageProfile StorageProfile { get; }
        /// <summary> The list of storage accounts in the cluster. </summary>
        public IList<StorageAccount> StorageStorageaccounts
        {
            get => StorageProfile?.Storageaccounts;
        }

        /// <summary> The minimal supported tls version. </summary>
        public string MinSupportedTlsVersion { get; }
        /// <summary> The excluded services config. </summary>
        public ExcludedServicesConfig ExcludedServicesConfig { get; }
        /// <summary> The network properties. </summary>
        public NetworkProperties NetworkProperties { get; }
        /// <summary> The compute isolation properties. </summary>
        public ComputeIsolationProperties ComputeIsolationProperties { get; }
        /// <summary> The private link configurations. </summary>
        public IReadOnlyList<PrivateLinkConfiguration> PrivateLinkConfigurations { get; }
        /// <summary> The list of private endpoint connections. </summary>
        public IReadOnlyList<HDInsightPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}

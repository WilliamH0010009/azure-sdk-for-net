// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a backup which will be performed. </summary>
    public partial class BackupRequest : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of BackupRequest. </summary>
        public BackupRequest()
        {
            Databases = new ChangeTrackingList<DatabaseBackupSetting>();
        }

        /// <summary> Initializes a new instance of BackupRequest. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="backupName"> Name of the backup. </param>
        /// <param name="enabled"> True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled. </param>
        /// <param name="storageAccountUrl"> SAS URL to the container. </param>
        /// <param name="backupSchedule"> Schedule for the backup if it is executed periodically. </param>
        /// <param name="databases"> Databases included in the backup. </param>
        internal BackupRequest(ResourceIdentifier id, string name, ResourceType type, string kind, string backupName, bool? enabled, string storageAccountUrl, BackupSchedule backupSchedule, IList<DatabaseBackupSetting> databases) : base(id, name, type, kind)
        {
            BackupName = backupName;
            Enabled = enabled;
            StorageAccountUrl = storageAccountUrl;
            BackupSchedule = backupSchedule;
            Databases = databases;
        }

        /// <summary> Name of the backup. </summary>
        public string BackupName { get; set; }
        /// <summary> True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> SAS URL to the container. </summary>
        public string StorageAccountUrl { get; set; }
        /// <summary> Schedule for the backup if it is executed periodically. </summary>
        public BackupSchedule BackupSchedule { get; set; }
        /// <summary> Databases included in the backup. </summary>
        public IList<DatabaseBackupSetting> Databases { get; }
    }
}

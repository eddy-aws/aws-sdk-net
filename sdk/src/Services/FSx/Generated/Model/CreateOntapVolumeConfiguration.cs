/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies the configuration of the ONTAP volume that you are creating.
    /// </summary>
    public partial class CreateOntapVolumeConfiguration
    {
        private string _junctionPath;
        private SecurityStyle _securityStyle;
        private int? _sizeInMegabytes;
        private bool? _storageEfficiencyEnabled;
        private string _storageVirtualMachineId;
        private TieringPolicy _tieringPolicy;

        /// <summary>
        /// Gets and sets the property JunctionPath. 
        /// <para>
        /// Specifies the location in the SVM's namespace where the volume is mounted. The <code>JunctionPath</code>
        /// must have a leading forward slash, such as <code>/vol3</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string JunctionPath
        {
            get { return this._junctionPath; }
            set { this._junctionPath = value; }
        }

        // Check to see if JunctionPath property is set
        internal bool IsSetJunctionPath()
        {
            return this._junctionPath != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityStyle. 
        /// <para>
        /// Specifies the security style for the volume. If a volume's security style is not specified,
        /// it is automatically set to the root volume's security style. The security style determines
        /// the type of permissions that FSx for ONTAP uses to control data access. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-volumes.html#volume-security-style">Volume
        /// security style</a> in the <i>Amazon FSx for NetApp ONTAP User Guide</i>. Specify one
        /// of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>UNIX</code> if the file system is managed by a UNIX administrator, the majority
        /// of users are NFS clients, and an application accessing the data uses a UNIX user as
        /// the service account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NTFS</code> if the file system is managed by a Windows administrator, the majority
        /// of users are SMB clients, and an application accessing the data uses a Windows user
        /// as the service account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MIXED</code> if the file system is managed by both UNIX and Windows administrators
        /// and users consist of both NFS and SMB clients.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SecurityStyle SecurityStyle
        {
            get { return this._securityStyle; }
            set { this._securityStyle = value; }
        }

        // Check to see if SecurityStyle property is set
        internal bool IsSetSecurityStyle()
        {
            return this._securityStyle != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInMegabytes. 
        /// <para>
        /// Specifies the size of the volume, in megabytes (MB), that you are creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int SizeInMegabytes
        {
            get { return this._sizeInMegabytes.GetValueOrDefault(); }
            set { this._sizeInMegabytes = value; }
        }

        // Check to see if SizeInMegabytes property is set
        internal bool IsSetSizeInMegabytes()
        {
            return this._sizeInMegabytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageEfficiencyEnabled. 
        /// <para>
        /// Set to true to enable deduplication, compression, and compaction storage efficiency
        /// features on the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool StorageEfficiencyEnabled
        {
            get { return this._storageEfficiencyEnabled.GetValueOrDefault(); }
            set { this._storageEfficiencyEnabled = value; }
        }

        // Check to see if StorageEfficiencyEnabled property is set
        internal bool IsSetStorageEfficiencyEnabled()
        {
            return this._storageEfficiencyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// Specifies the ONTAP SVM in which to create the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string StorageVirtualMachineId
        {
            get { return this._storageVirtualMachineId; }
            set { this._storageVirtualMachineId = value; }
        }

        // Check to see if StorageVirtualMachineId property is set
        internal bool IsSetStorageVirtualMachineId()
        {
            return this._storageVirtualMachineId != null;
        }

        /// <summary>
        /// Gets and sets the property TieringPolicy.
        /// </summary>
        public TieringPolicy TieringPolicy
        {
            get { return this._tieringPolicy; }
            set { this._tieringPolicy = value; }
        }

        // Check to see if TieringPolicy property is set
        internal bool IsSetTieringPolicy()
        {
            return this._tieringPolicy != null;
        }

    }
}
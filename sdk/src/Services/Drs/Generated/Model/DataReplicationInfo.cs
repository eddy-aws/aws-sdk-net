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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Information about Data Replication
    /// </summary>
    public partial class DataReplicationInfo
    {
        private DataReplicationError _dataReplicationError;
        private DataReplicationInitiation _dataReplicationInitiation;
        private DataReplicationState _dataReplicationState;
        private string _etaDateTime;
        private string _lagDuration;
        private List<DataReplicationInfoReplicatedDisk> _replicatedDisks = new List<DataReplicationInfoReplicatedDisk>();

        /// <summary>
        /// Gets and sets the property DataReplicationError. 
        /// <para>
        /// Error in data replication.
        /// </para>
        /// </summary>
        public DataReplicationError DataReplicationError
        {
            get { return this._dataReplicationError; }
            set { this._dataReplicationError = value; }
        }

        // Check to see if DataReplicationError property is set
        internal bool IsSetDataReplicationError()
        {
            return this._dataReplicationError != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationInitiation. 
        /// <para>
        /// Information about whether the data replication has been initiated.
        /// </para>
        /// </summary>
        public DataReplicationInitiation DataReplicationInitiation
        {
            get { return this._dataReplicationInitiation; }
            set { this._dataReplicationInitiation = value; }
        }

        // Check to see if DataReplicationInitiation property is set
        internal bool IsSetDataReplicationInitiation()
        {
            return this._dataReplicationInitiation != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationState. 
        /// <para>
        /// The state of the data replication.
        /// </para>
        /// </summary>
        public DataReplicationState DataReplicationState
        {
            get { return this._dataReplicationState; }
            set { this._dataReplicationState = value; }
        }

        // Check to see if DataReplicationState property is set
        internal bool IsSetDataReplicationState()
        {
            return this._dataReplicationState != null;
        }

        /// <summary>
        /// Gets and sets the property EtaDateTime. 
        /// <para>
        /// An estimate of when the data replication will be completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string EtaDateTime
        {
            get { return this._etaDateTime; }
            set { this._etaDateTime = value; }
        }

        // Check to see if EtaDateTime property is set
        internal bool IsSetEtaDateTime()
        {
            return this._etaDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property LagDuration. 
        /// <para>
        /// Data replication lag duration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LagDuration
        {
            get { return this._lagDuration; }
            set { this._lagDuration = value; }
        }

        // Check to see if LagDuration property is set
        internal bool IsSetLagDuration()
        {
            return this._lagDuration != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicatedDisks. 
        /// <para>
        /// The disks that should be replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public List<DataReplicationInfoReplicatedDisk> ReplicatedDisks
        {
            get { return this._replicatedDisks; }
            set { this._replicatedDisks = value; }
        }

        // Check to see if ReplicatedDisks property is set
        internal bool IsSetReplicatedDisks()
        {
            return this._replicatedDisks != null && this._replicatedDisks.Count > 0; 
        }

    }
}
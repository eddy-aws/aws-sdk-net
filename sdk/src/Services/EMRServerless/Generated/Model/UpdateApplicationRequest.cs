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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates a specified application. An application has to be in a stopped or created
    /// state in order to be updated.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonEMRServerlessRequest
    {
        private string _applicationId;
        private AutoStartConfig _autoStartConfiguration;
        private AutoStopConfig _autoStopConfiguration;
        private string _clientToken;
        private Dictionary<string, InitialCapacityConfig> _initialCapacity = new Dictionary<string, InitialCapacityConfig>();
        private MaximumAllowedResources _maximumCapacity;
        private NetworkConfiguration _networkConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AutoStartConfiguration. 
        /// <para>
        /// The configuration for an application to automatically start on job submission.
        /// </para>
        /// </summary>
        public AutoStartConfig AutoStartConfiguration
        {
            get { return this._autoStartConfiguration; }
            set { this._autoStartConfiguration = value; }
        }

        // Check to see if AutoStartConfiguration property is set
        internal bool IsSetAutoStartConfiguration()
        {
            return this._autoStartConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoStopConfiguration. 
        /// <para>
        /// The configuration for an application to automatically stop after a certain amount
        /// of time being idle.
        /// </para>
        /// </summary>
        public AutoStopConfig AutoStopConfiguration
        {
            get { return this._autoStopConfiguration; }
            set { this._autoStopConfiguration = value; }
        }

        // Check to see if AutoStopConfiguration property is set
        internal bool IsSetAutoStopConfiguration()
        {
            return this._autoStopConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the application to update. Its value must be unique
        /// for each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InitialCapacity. 
        /// <para>
        /// The capacity to initialize when the application is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, InitialCapacityConfig> InitialCapacity
        {
            get { return this._initialCapacity; }
            set { this._initialCapacity = value; }
        }

        // Check to see if InitialCapacity property is set
        internal bool IsSetInitialCapacity()
        {
            return this._initialCapacity != null && this._initialCapacity.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaximumCapacity. 
        /// <para>
        /// The maximum capacity to allocate when the application is updated. This is cumulative
        /// across all workers at any given point in time during the lifespan of the application.
        /// No new resources will be created once any one of the defined limits is hit.
        /// </para>
        /// </summary>
        public MaximumAllowedResources MaximumCapacity
        {
            get { return this._maximumCapacity; }
            set { this._maximumCapacity = value; }
        }

        // Check to see if MaximumCapacity property is set
        internal bool IsSetMaximumCapacity()
        {
            return this._maximumCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration.
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

    }
}
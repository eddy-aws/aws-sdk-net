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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The output configuration for this channel.
    /// </summary>
    public partial class RequestOutputItem
    {
        private DashPlaylistSettings _dashPlaylistSettings;
        private HlsPlaylistSettings _hlsPlaylistSettings;
        private string _manifestName;
        private string _sourceGroup;

        /// <summary>
        /// Gets and sets the property DashPlaylistSettings. 
        /// <para>
        /// DASH manifest configuration parameters.
        /// </para>
        /// </summary>
        public DashPlaylistSettings DashPlaylistSettings
        {
            get { return this._dashPlaylistSettings; }
            set { this._dashPlaylistSettings = value; }
        }

        // Check to see if DashPlaylistSettings property is set
        internal bool IsSetDashPlaylistSettings()
        {
            return this._dashPlaylistSettings != null;
        }

        /// <summary>
        /// Gets and sets the property HlsPlaylistSettings. 
        /// <para>
        /// HLS playlist configuration parameters.
        /// </para>
        /// </summary>
        public HlsPlaylistSettings HlsPlaylistSettings
        {
            get { return this._hlsPlaylistSettings; }
            set { this._hlsPlaylistSettings = value; }
        }

        // Check to see if HlsPlaylistSettings property is set
        internal bool IsSetHlsPlaylistSettings()
        {
            return this._hlsPlaylistSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. 
        /// <para>
        /// The name of the manifest for the channel. The name appears in the PlaybackUrl.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceGroup. 
        /// <para>
        /// A string used to match which HttpPackageConfiguration is used for each VodSource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceGroup
        {
            get { return this._sourceGroup; }
            set { this._sourceGroup = value; }
        }

        // Check to see if SourceGroup property is set
        internal bool IsSetSourceGroup()
        {
            return this._sourceGroup != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides you with the Amazon S3 URI you can use to access your transcript.
    /// </summary>
    public partial class MedicalTranscript
    {
        private string _transcriptFileUri;

        /// <summary>
        /// Gets and sets the property TranscriptFileUri. 
        /// <para>
        /// The Amazon S3 location of your transcript. You can use this URI to access or download
        /// your transcript.
        /// </para>
        ///  
        /// <para>
        /// If you included <code>OutputBucketName</code> in your transcription job request, this
        /// is the URI of that bucket. If you also included <code>OutputKey</code> in your request,
        /// your output is located in the path you specified in your request.
        /// </para>
        ///  
        /// <para>
        /// If you didn't include <code>OutputBucketName</code> in your transcription job request,
        /// your transcript is stored in a service-managed bucket, and <code>TranscriptFileUri</code>
        /// provides you with a temporary URI you can use for secure access to your transcript.
        /// </para>
        ///  <note> 
        /// <para>
        /// Temporary URIs for service-managed Amazon S3 buckets are only valid for 15 minutes.
        /// If you get an <code>AccesDenied</code> error, you can get a new temporary URI by running
        /// a <code>GetTranscriptionJob</code> or <code>ListTranscriptionJob</code> request.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string TranscriptFileUri
        {
            get { return this._transcriptFileUri; }
            set { this._transcriptFileUri = value; }
        }

        // Check to see if TranscriptFileUri property is set
        internal bool IsSetTranscriptFileUri()
        {
            return this._transcriptFileUri != null;
        }

    }
}
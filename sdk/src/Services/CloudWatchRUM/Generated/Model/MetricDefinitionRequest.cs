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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Use this structure to define one extended metric that RUM will send to CloudWatch
    /// or CloudWatch Evidently. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
    /// Additional metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
    /// 
    ///  
    /// <para>
    /// Only certain combinations of values for <code>Name</code>, <code>ValueKey</code>,
    /// and <code>EventPattern</code> are valid. In addition to what is displayed in the list
    /// below, the <code>EventPattern</code> can also include information used by the <code>DimensionKeys</code>
    /// field.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If <code>Name</code> is <code>PerformanceNavigationDuration</code>, then <code>ValueKey</code>must
    /// be <code>event_details.duration</code> and the <code>EventPattern</code> must include
    /// <code>{"event_type":["com.amazon.rum.performance_navigation_event"]}</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>PerformanceResourceDuration</code>, then <code>ValueKey</code>must
    /// be <code>event_details.duration</code> and the <code>EventPattern</code> must include
    /// <code>{"event_type":["com.amazon.rum.performance_resource_event"]}</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>NavigationSatisfiedTransaction</code>, then <code>ValueKey</code>must
    /// be null and the <code>EventPattern</code> must include <code>{ "event_type": ["com.amazon.rum.performance_navigation_event"],
    /// "event_details": { "duration": [{ "numeric": ["&gt;",2000] }] } }</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>NavigationToleratedTransaction</code>, then <code>ValueKey</code>must
    /// be null and the <code>EventPattern</code> must include <code>{ "event_type": ["com.amazon.rum.performance_navigation_event"],
    /// "event_details": { "duration": [{ "numeric": ["&gt;=",2000,"&lt;"8000] }] } }</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>NavigationFrustratedTransaction</code>, then <code>ValueKey</code>must
    /// be null and the <code>EventPattern</code> must include <code>{ "event_type": ["com.amazon.rum.performance_navigation_event"],
    /// "event_details": { "duration": [{ "numeric": ["&gt;=",8000] }] } }</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>WebVitalsCumulativeLayoutShift</code>, then <code>ValueKey</code>must
    /// be <code>event_details.value</code> and the <code>EventPattern</code> must include
    /// <code>{"event_type":["com.amazon.rum.cumulative_layout_shift_event"]}</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>WebVitalsFirstInputDelay</code>, then <code>ValueKey</code>must
    /// be <code>event_details.value</code> and the <code>EventPattern</code> must include
    /// <code>{"event_type":["com.amazon.rum.first_input_delay_event"]}</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>WebVitalsLargestContentfulPaint</code>, then <code>ValueKey</code>must
    /// be <code>event_details.value</code> and the <code>EventPattern</code> must include
    /// <code>{"event_type":["com.amazon.rum.largest_contentful_paint_event"]}</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>JsErrorCount</code>, then <code>ValueKey</code>must
    /// be null and the <code>EventPattern</code> must include <code>{"event_type":["com.amazon.rum.js_error_event"]}</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>HttpErrorCount</code>, then <code>ValueKey</code>must
    /// be null and the <code>EventPattern</code> must include <code>{"event_type":["com.amazon.rum.http_event"]}</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <code>Name</code> is <code>SessionCount</code>, then <code>ValueKey</code>must
    /// be null and the <code>EventPattern</code> must include <code>{"event_type":["com.amazon.rum.session_start_event"]}</code>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MetricDefinitionRequest
    {
        private Dictionary<string, string> _dimensionKeys = new Dictionary<string, string>();
        private string _eventPattern;
        private string _name;
        private string _unitLabel;
        private string _valueKey;

        /// <summary>
        /// Gets and sets the property DimensionKeys. 
        /// <para>
        /// Use this field only if you are sending the metric to CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// This field is a map of field paths to dimension names. It defines the dimensions to
        /// associate with this metric in CloudWatch. Valid values for the entries in this field
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"metadata.pageId": "PageId"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"metadata.browserName": "BrowserName"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"metadata.deviceType": "DeviceType"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"metadata.osName": "OSName"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"metadata.countryCode": "CountryCode"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"event_details.fileType": "FileType"</code> 
        /// </para>
        ///  </li> </ul> <pre><code> &lt;p&gt; All dimensions listed in this field must also be
        /// included in &lt;code&gt;EventPattern&lt;/code&gt;.&lt;/p&gt; </code></pre>
        /// </summary>
        public Dictionary<string, string> DimensionKeys
        {
            get { return this._dimensionKeys; }
            set { this._dimensionKeys = value; }
        }

        // Check to see if DimensionKeys property is set
        internal bool IsSetDimensionKeys()
        {
            return this._dimensionKeys != null && this._dimensionKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The pattern that defines the metric, specified as a JSON object. RUM checks events
        /// that happen in a user's session against the pattern, and events that match the pattern
        /// are sent to the metric destination.
        /// </para>
        ///  
        /// <para>
        /// When you define extended metrics, the metric definition is not valid if <code>EventPattern</code>
        /// is omitted.
        /// </para>
        ///  
        /// <para>
        /// Example event patterns:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>'{ "event_type": ["com.amazon.rum.js_error_event"], "metadata": { "browserName":
        /// [ "Chrome", "Safari" ], } }'</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>'{ "event_type": ["com.amazon.rum.performance_navigation_event"], "metadata":
        /// { "browserName": [ "Chrome", "Firefox" ] }, "event_details": { "duration": [{ "numeric":
        /// [ "&lt;", 2000 ] }] } }'</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>'{ "event_type": ["com.amazon.rum.performance_navigation_event"], "metadata":
        /// { "browserName": [ "Chrome", "Safari" ], "countryCode": [ "US" ] }, "event_details":
        /// { "duration": [{ "numeric": [ "&gt;=", 2000, "&lt;", 8000 ] }] } }'</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the metrics destination' is <code>CloudWatch</code> and the event also matches
        /// a value in <code>DimensionKeys</code>, then the metric is published with the specified
        /// dimensions. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4000)]
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the metric that is defined in this structure. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PerformanceNavigationDuration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PerformanceResourceDuration </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NavigationSatisfiedTransaction</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NavigationToleratedTransaction</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NavigationFrustratedTransaction</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WebVitalsCumulativeLayoutShift</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WebVitalsFirstInputDelay</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WebVitalsLargestContentfulPaint</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JsErrorCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpErrorCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SessionCount</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UnitLabel. 
        /// <para>
        /// The CloudWatch metric unit to use for this metric. If you omit this field, the metric
        /// is recorded with no unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UnitLabel
        {
            get { return this._unitLabel; }
            set { this._unitLabel = value; }
        }

        // Check to see if UnitLabel property is set
        internal bool IsSetUnitLabel()
        {
            return this._unitLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ValueKey. 
        /// <para>
        /// The field within the event object that the metric value is sourced from.
        /// </para>
        ///  
        /// <para>
        /// If you omit this field, a hardcoded value of 1 is pushed as the metric value. This
        /// is useful if you just want to count the number of events that the filter catches.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If this metric is sent to CloudWatch Evidently, this field will be passed to Evidently
        /// raw and Evidently will handle data extraction from the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=280)]
        public string ValueKey
        {
            get { return this._valueKey; }
            set { this._valueKey = value; }
        }

        // Check to see if ValueKey property is set
        internal bool IsSetValueKey()
        {
            return this._valueKey != null;
        }

    }
}
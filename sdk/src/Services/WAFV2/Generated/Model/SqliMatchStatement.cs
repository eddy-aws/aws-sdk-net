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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement that inspects for malicious SQL code. Attackers insert malicious
    /// SQL code into web requests to do things like modify your database or extract data
    /// from it.
    /// </summary>
    public partial class SqliMatchStatement
    {
        private FieldToMatch _fieldToMatch;
        private SensitivityLevel _sensitivityLevel;
        private List<TextTransformation> _textTransformations = new List<TextTransformation>();

        /// <summary>
        /// Gets and sets the property FieldToMatch. 
        /// <para>
        /// The part of the web request that you want WAF to inspect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldToMatch FieldToMatch
        {
            get { return this._fieldToMatch; }
            set { this._fieldToMatch = value; }
        }

        // Check to see if FieldToMatch property is set
        internal bool IsSetFieldToMatch()
        {
            return this._fieldToMatch != null;
        }

        /// <summary>
        /// Gets and sets the property SensitivityLevel. 
        /// <para>
        /// The sensitivity that you want WAF to use to inspect for SQL injection attacks. 
        /// </para>
        ///  
        /// <para>
        ///  <code>HIGH</code> detects more attacks, but might generate more false positives,
        /// especially if your web requests frequently contain unusual strings. For information
        /// about identifying and mitigating false positives, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/web-acl-testing.html">Testing
        /// and tuning</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <code>LOW</code> is generally a better choice for resources that already have other
        /// protections against SQL injection attacks or that have a low tolerance for false positives.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>LOW</code> 
        /// </para>
        /// </summary>
        public SensitivityLevel SensitivityLevel
        {
            get { return this._sensitivityLevel; }
            set { this._sensitivityLevel = value; }
        }

        // Check to see if SensitivityLevel property is set
        internal bool IsSetSensitivityLevel()
        {
            return this._sensitivityLevel != null;
        }

        /// <summary>
        /// Gets and sets the property TextTransformations. 
        /// <para>
        /// Text transformations eliminate some of the unusual formatting that attackers use in
        /// web requests in an effort to bypass detection. If you specify one or more transformations
        /// in a rule statement, WAF performs all transformations on the content of the request
        /// component identified by <code>FieldToMatch</code>, starting from the lowest priority
        /// setting, before inspecting the content for a match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<TextTransformation> TextTransformations
        {
            get { return this._textTransformations; }
            set { this._textTransformations = value; }
        }

        // Check to see if TextTransformations property is set
        internal bool IsSetTextTransformations()
        {
            return this._textTransformations != null && this._textTransformations.Count > 0; 
        }

    }
}
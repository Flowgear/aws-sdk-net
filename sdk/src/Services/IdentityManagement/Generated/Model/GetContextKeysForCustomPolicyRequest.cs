/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetContextKeysForCustomPolicy operation.
    /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
    /// in the input policies. The policies are supplied as a list of one or more strings.
    /// To get the context keys from policies associated with an IAM user, group, or role,
    /// use <a>GetContextKeysForPrincipalPolicy</a>.
    /// 
    ///  
    /// <para>
    /// Context keys are variables maintained by AWS and its services that provide details
    /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
    /// element of an IAM policy. Use GetContextKeysForCustomPolicy to understand what key
    /// names and values you must supply when you call <a>SimulateCustomPolicy</a>. Note that
    /// all parameters are shown in unencoded form here for clarity, but must be URL encoded
    /// to be included as a part of a real HTML request.
    /// </para>
    /// </summary>
    public partial class GetContextKeysForCustomPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _policyInputList = new List<string>();

        /// <summary>
        /// Gets and sets the property PolicyInputList. 
        /// <para>
        /// A list of policies for which you want list of context keys used in <code>Condition</code>
        /// elements. Each document is specified as a string containing the complete, valid JSON
        /// text of an IAM policy.
        /// </para>
        /// </summary>
        public List<string> PolicyInputList
        {
            get { return this._policyInputList; }
            set { this._policyInputList = value; }
        }

        // Check to see if PolicyInputList property is set
        internal bool IsSetPolicyInputList()
        {
            return this._policyInputList != null && this._policyInputList.Count > 0; 
        }

    }
}
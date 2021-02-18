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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSHealth.Model;

namespace Amazon.AWSHealth
{
    /// <summary>
    /// Interface for accessing AWSHealth
    ///
    /// AWS Health 
    /// <para>
    /// The AWS Health API provides programmatic access to the AWS Health information that
    /// appears in the <a href="https://phd.aws.amazon.com/phd/home#/">AWS Personal Health
    /// Dashboard</a>. You can use the API operations to get information about AWS Health
    /// events that affect your AWS services and resources.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must have a Business or Enterprise support plan from <a href="http://aws.amazon.com/premiumsupport/">AWS
    /// Support</a> to use the AWS Health API. If you call the AWS Health API from an AWS
    /// account that doesn't have a Business or Enterprise support plan, you receive a <code>SubscriptionRequiredException</code>
    /// error.
    /// </para>
    ///  </note> 
    /// <para>
    /// AWS Health has a single endpoint: health.us-east-1.amazonaws.com (HTTPS). Use this
    /// endpoint to call the AWS Health API operations.
    /// </para>
    ///  
    /// <para>
    /// For authentication of requests, AWS Health uses the <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// If your AWS account is part of AWS Organizations, you can use the AWS Health organizational
    /// view feature. This feature provides a centralized view of AWS Health events across
    /// all accounts in your organization. You can aggregate AWS Health events in real time
    /// to identify accounts in your organization that are affected by an operational event
    /// or get notified of security vulnerabilities. Use the organizational view API operations
    /// to enable this feature and return event information. For more information, see <a
    /// href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
    /// AWS Health events</a> in the <i>AWS Health User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you use the AWS Health API operations to return AWS Health events, see the following
    /// recommendations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html#AWSHealth-Type-Event-eventScopeCode">eventScopeCode</a>
    /// parameter to specify whether to return AWS Health events that are public or account-specific.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use pagination to view all events from the response. For example, if you call the
    /// <code>DescribeEventsForOrganization</code> operation to get all events in your organization,
    /// you might receive several page results. Specify the <code>nextToken</code> in the
    /// next request to return more results.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial interface IAmazonAWSHealth : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAWSHealthPaginatorFactory Paginators { get; }
#endif


        
        #region  DescribeAffectedAccountsForOrganization


        /// <summary>
        /// Returns a list of accounts in the organization from AWS Organizations that are affected
        /// by the provided event. For more information about the different types of AWS Health
        /// events, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedAccountsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedAccountsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        DescribeAffectedAccountsForOrganizationResponse DescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAffectedAccountsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedAccountsForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAffectedAccountsForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        IAsyncResult BeginDescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAffectedAccountsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAffectedAccountsForOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeAffectedAccountsForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        DescribeAffectedAccountsForOrganizationResponse EndDescribeAffectedAccountsForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAffectedEntities


        /// <summary>
        /// Returns a list of entities that have been affected by the specified events, based
        /// on the specified filter criteria. Entities can refer to individual customer resources,
        /// groups of customer resources, or any other construct, depending on the AWS service.
        /// Events that have impact beyond that of the affected entities, or where the extent
        /// of impact is unknown, include at least one entity indicating this.
        /// 
        ///  
        /// <para>
        /// At least one event ARN is required. Results are sorted by the <code>lastUpdatedTime</code>
        /// of the entity, starting with the most recent.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation supports resource-level permissions. You can use this operation to
        /// allow or deny access to specific AWS Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>AWS Health User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntities service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedEntities service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        DescribeAffectedEntitiesResponse DescribeAffectedEntities(DescribeAffectedEntitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAffectedEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntities operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAffectedEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        IAsyncResult BeginDescribeAffectedEntities(DescribeAffectedEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAffectedEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAffectedEntities.</param>
        /// 
        /// <returns>Returns a  DescribeAffectedEntitiesResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        DescribeAffectedEntitiesResponse EndDescribeAffectedEntities(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAffectedEntitiesForOrganization


        /// <summary>
        /// Returns a list of entities that have been affected by one or more events for one or
        /// more accounts in your organization in AWS Organizations, based on the filter criteria.
        /// Entities can refer to individual customer resources, groups of customer resources,
        /// or any other construct, depending on the AWS service.
        /// 
        ///  
        /// <para>
        /// At least one event Amazon Resource Name (ARN) and account ID are required. Results
        /// are sorted by the <code>lastUpdatedTime</code> of the entity, starting with the most
        /// recent.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation doesn't support resource-level permissions. You can't use this operation
        /// to allow or deny access to specific AWS Health events. For more information, see <a
        /// href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>AWS Health User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntitiesForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedEntitiesForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        DescribeAffectedEntitiesForOrganizationResponse DescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAffectedEntitiesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntitiesForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAffectedEntitiesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        IAsyncResult BeginDescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAffectedEntitiesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAffectedEntitiesForOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeAffectedEntitiesForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        DescribeAffectedEntitiesForOrganizationResponse EndDescribeAffectedEntitiesForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEntityAggregates


        /// <summary>
        /// Returns the number of entities that are affected by each of the specified events.
        /// If no events are specified, the counts of all affected entities are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregates service method.</param>
        /// 
        /// <returns>The response from the DescribeEntityAggregates service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        DescribeEntityAggregatesResponse DescribeEntityAggregates(DescribeEntityAggregatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntityAggregates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregates operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntityAggregates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        IAsyncResult BeginDescribeEntityAggregates(DescribeEntityAggregatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntityAggregates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntityAggregates.</param>
        /// 
        /// <returns>Returns a  DescribeEntityAggregatesResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        DescribeEntityAggregatesResponse EndDescribeEntityAggregates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventAggregates


        /// <summary>
        /// Returns the number of events of each event type (issue, scheduled change, and account
        /// notification). If no filter is specified, the counts of all events in each category
        /// are returned.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventAggregates service method.</param>
        /// 
        /// <returns>The response from the DescribeEventAggregates service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        DescribeEventAggregatesResponse DescribeEventAggregates(DescribeEventAggregatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventAggregates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventAggregates operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventAggregates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        IAsyncResult BeginDescribeEventAggregates(DescribeEventAggregatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventAggregates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventAggregates.</param>
        /// 
        /// <returns>Returns a  DescribeEventAggregatesResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        DescribeEventAggregatesResponse EndDescribeEventAggregates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventDetails


        /// <summary>
        /// Returns detailed information about one or more specified events. Information includes
        /// standard event data (AWS Region, service, and so on, as returned by <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>),
        /// a detailed event description, and possible additional metadata that depends upon the
        /// nature of the event. Affected entities are not included. To retrieve those, use the
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// If a specified event cannot be retrieved, an error message is returned for that event.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation supports resource-level permissions. You can use this operation to
        /// allow or deny access to specific AWS Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>AWS Health User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetails service method.</param>
        /// 
        /// <returns>The response from the DescribeEventDetails service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        DescribeEventDetailsResponse DescribeEventDetails(DescribeEventDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetails operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        IAsyncResult BeginDescribeEventDetails(DescribeEventDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventDetails.</param>
        /// 
        /// <returns>Returns a  DescribeEventDetailsResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        DescribeEventDetailsResponse EndDescribeEventDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventDetailsForOrganization


        /// <summary>
        /// Returns detailed information about one or more specified events for one or more accounts
        /// in your organization. Information includes standard event data (AWS Region, service,
        /// and so on, as returned by <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventsForOrganization.html">DescribeEventsForOrganization</a>),
        /// a detailed event description, and possible additional metadata that depends upon the
        /// nature of the event. Affected entities are not included; to retrieve those, use the
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  
        /// <para>
        /// When you call the <code>DescribeEventDetailsForOrganization</code> operation, you
        /// specify the <code>organizationEventDetailFilters</code> object in the request. Depending
        /// on the AWS Health event type, note the following differences:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the event is public, the <code>awsAccountId</code> parameter must be empty. If
        /// you specify an account ID for a public event, then an error message is returned. That's
        /// because the event might apply to all AWS accounts and isn't specific to an account
        /// in your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the event is specific to an account, then you must specify the <code>awsAccountId</code>
        /// parameter in the request. If you don't specify an account ID, an error message returns
        /// because the event is specific to an AWS account in your organization. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation doesn't support resource-level permissions. You can't use this operation
        /// to allow or deny access to specific AWS Health events. For more information, see <a
        /// href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>AWS Health User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetailsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEventDetailsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        DescribeEventDetailsForOrganizationResponse DescribeEventDetailsForOrganization(DescribeEventDetailsForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventDetailsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetailsForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventDetailsForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        IAsyncResult BeginDescribeEventDetailsForOrganization(DescribeEventDetailsForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventDetailsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventDetailsForOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeEventDetailsForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        DescribeEventDetailsForOrganizationResponse EndDescribeEventDetailsForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns information about events that meet the specified filter criteria. Events
        /// are returned in a summary form and do not include the detailed description, any additional
        /// metadata that depends on the event type, or any affected resources. To retrieve that
        /// information, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetails.html">DescribeEventDetails</a>
        /// and <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events are returned. Results are sorted by
        /// <code>lastModifiedTime</code>, starting with the most recent event.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// When you call the <code>DescribeEvents</code> operation and specify an entity for
        /// the <code>entityValues</code> parameter, AWS Health might return public events that
        /// aren't specific to that resource. For example, if you call <code>DescribeEvents</code>
        /// and specify an ID for an Amazon Elastic Compute Cloud (Amazon EC2) instance, AWS Health
        /// might return events that aren't specific to that resource or service. To get events
        /// that are specific to a service, use the <code>services</code> parameter in the <code>filter</code>
        /// object. For more information, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventsForOrganization


        /// <summary>
        /// Returns information about events across your organization in AWS Organizations. You
        /// can use the<code>filters</code> parameter to specify the events that you want to return.
        /// Events are returned in a summary form and don't include the affected accounts, detailed
        /// description, any additional metadata that depends on the event type, or any affected
        /// resources. To retrieve that information, use the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedAccountsForOrganization.html">DescribeAffectedAccountsForOrganization</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetailsForOrganization.html">DescribeEventDetailsForOrganization</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <code>filter</code>, the <code>DescribeEventsForOrganizations</code>
        /// returns all events across your organization. Results are sorted by <code>lastModifiedTime</code>,
        /// starting with the most recent event. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the different types of AWS Health events, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable AWS Health to work with
        /// AWS Organizations. To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEventsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        DescribeEventsForOrganizationResponse DescribeEventsForOrganization(DescribeEventsForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventsForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        IAsyncResult BeginDescribeEventsForOrganization(DescribeEventsForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventsForOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeEventsForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        DescribeEventsForOrganizationResponse EndDescribeEventsForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventTypes


        /// <summary>
        /// Returns the event types that meet the specified filter criteria. You can use this
        /// API operation to find information about the AWS Health event, such as the category,
        /// AWS service, and event code. The metadata for each event appears in the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EventType.html">EventType</a>
        /// object. 
        /// 
        ///  
        /// <para>
        /// If you don't specify a filter criteria, the API operation returns all event types,
        /// in no particular order. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEventTypes service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<code>nextToken</code>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        DescribeEventTypesResponse DescribeEventTypes(DescribeEventTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTypes operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        IAsyncResult BeginDescribeEventTypes(DescribeEventTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventTypes.</param>
        /// 
        /// <returns>Returns a  DescribeEventTypesResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        DescribeEventTypesResponse EndDescribeEventTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHealthServiceStatusForOrganization


        /// <summary>
        /// This operation provides status information on enabling or disabling AWS Health to
        /// work with your organization. To call this operation, you must sign in as an IAM user,
        /// assume an IAM role, or sign in as the root user (not recommended) in the organization's
        /// management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHealthServiceStatusForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeHealthServiceStatusForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        DescribeHealthServiceStatusForOrganizationResponse DescribeHealthServiceStatusForOrganization(DescribeHealthServiceStatusForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHealthServiceStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHealthServiceStatusForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHealthServiceStatusForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        IAsyncResult BeginDescribeHealthServiceStatusForOrganization(DescribeHealthServiceStatusForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHealthServiceStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHealthServiceStatusForOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeHealthServiceStatusForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        DescribeHealthServiceStatusForOrganizationResponse EndDescribeHealthServiceStatusForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableHealthServiceAccessForOrganization


        /// <summary>
        /// Disables AWS Health from working with AWS Organizations. To call this operation, you
        /// must sign in as an AWS Identity and Access Management (IAM) user, assume an IAM role,
        /// or sign in as the root user (not recommended) in the organization's management account.
        /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
        /// AWS Health events</a> in the <i>AWS Health User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation doesn't remove the service-linked role from the management account
        /// in your organization. You must use the IAM console, API, or AWS Command Line Interface
        /// (AWS CLI) to remove the service-linked role. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html#delete-service-linked-role">Deleting
        /// a Service-Linked Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also disable the organizational feature by using the Organizations <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_DisableAWSServiceAccess.html">DisableAWSServiceAccess</a>
        /// API operation. After you call this operation, AWS Health stops aggregating events
        /// for all other AWS accounts in your organization. If you call the AWS Health API operations
        /// for organizational view, AWS Health returns an error. AWS Health continues to aggregate
        /// health events for your AWS account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHealthServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the DisableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// is already in progress. Wait for the action to complete before trying again. To get
        /// the current status, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeHealthServiceStatusForOrganization.html">DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        DisableHealthServiceAccessForOrganizationResponse DisableHealthServiceAccessForOrganization(DisableHealthServiceAccessForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableHealthServiceAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableHealthServiceAccessForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableHealthServiceAccessForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        IAsyncResult BeginDisableHealthServiceAccessForOrganization(DisableHealthServiceAccessForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableHealthServiceAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableHealthServiceAccessForOrganization.</param>
        /// 
        /// <returns>Returns a  DisableHealthServiceAccessForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        DisableHealthServiceAccessForOrganizationResponse EndDisableHealthServiceAccessForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableHealthServiceAccessForOrganization


        /// <summary>
        /// Enables AWS Health to work with AWS Organizations. You can use the organizational
        /// view feature to aggregate events from all AWS accounts in your organization in a centralized
        /// location. 
        /// 
        ///  
        /// <para>
        /// This operation also creates a service-linked role for the management account in the
        /// organization. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To call this operation, you must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must have a Business or Enterprise support plan from <a href="http://aws.amazon.com/premiumsupport/">AWS
        /// Support</a> to use the AWS Health API. If you call the AWS Health API from an AWS
        /// account that doesn't have a Business or Enterprise support plan, you receive a <code>SubscriptionRequiredException</code>
        /// error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have permission to call this operation from the organization's management
        /// account. For example IAM policies, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html">AWS
        /// Health identity-based policy examples</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// If you don't have the required support plan, you can instead use the AWS Health console
        /// to enable the organizational view feature. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
        /// AWS Health events</a> in the <i>AWS Health User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHealthServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the EnableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// is already in progress. Wait for the action to complete before trying again. To get
        /// the current status, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeHealthServiceStatusForOrganization.html">DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        EnableHealthServiceAccessForOrganizationResponse EnableHealthServiceAccessForOrganization(EnableHealthServiceAccessForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableHealthServiceAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableHealthServiceAccessForOrganization operation on AmazonAWSHealthClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableHealthServiceAccessForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        IAsyncResult BeginEnableHealthServiceAccessForOrganization(EnableHealthServiceAccessForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableHealthServiceAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableHealthServiceAccessForOrganization.</param>
        /// 
        /// <returns>Returns a  EnableHealthServiceAccessForOrganizationResult from AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        EnableHealthServiceAccessForOrganizationResponse EndEnableHealthServiceAccessForOrganization(IAsyncResult asyncResult);

        #endregion
        
    }
}
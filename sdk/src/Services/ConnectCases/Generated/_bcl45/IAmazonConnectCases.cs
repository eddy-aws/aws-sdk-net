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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectCases.Model;

namespace Amazon.ConnectCases
{
    /// <summary>
    /// Interface for accessing ConnectCases
    ///
    /// Welcome to the Amazon Connect Cases API Reference. This guide provides information
    /// about the Amazon Connect Cases API, which you can use to create, update, get, and
    /// list Cases domains, fields, field options, layouts, templates, cases, related items,
    /// and tags.
    /// 
    ///  <pre><code> &lt;p&gt;For more information about Amazon Connect Cases, see &lt;a href=&quot;https://docs.aws.amazon.com/connect/latest/adminguide/cases.html&quot;&gt;Amazon
    /// Connect Cases&lt;/a&gt; in the &lt;i&gt;Amazon Connect Administrator Guide&lt;/i&gt;.
    /// &lt;/p&gt; </code></pre>
    /// </summary>
    public partial interface IAmazonConnectCases : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectCasesPaginatorFactory Paginators { get; }

        
        #region  BatchGetField


        /// <summary>
        /// Returns the description for the list of fields in the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetField service method.</param>
        /// 
        /// <returns>The response from the BatchGetField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetField">REST API Reference for BatchGetField Operation</seealso>
        BatchGetFieldResponse BatchGetField(BatchGetFieldRequest request);



        /// <summary>
        /// Returns the description for the list of fields in the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetField">REST API Reference for BatchGetField Operation</seealso>
        Task<BatchGetFieldResponse> BatchGetFieldAsync(BatchGetFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchPutFieldOptions


        /// <summary>
        /// Creates and updates a set of field options for a single select field in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutFieldOptions service method.</param>
        /// 
        /// <returns>The response from the BatchPutFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchPutFieldOptions">REST API Reference for BatchPutFieldOptions Operation</seealso>
        BatchPutFieldOptionsResponse BatchPutFieldOptions(BatchPutFieldOptionsRequest request);



        /// <summary>
        /// Creates and updates a set of field options for a single select field in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutFieldOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchPutFieldOptions">REST API Reference for BatchPutFieldOptions Operation</seealso>
        Task<BatchPutFieldOptionsResponse> BatchPutFieldOptionsAsync(BatchPutFieldOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCase


        /// <summary>
        /// Creates a case in the specified Cases domain. Case system and custom fields are taken
        /// as an array id/value pairs with a declared data types.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>customer_id</code> is a required field when creating a case.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCase">REST API Reference for CreateCase Operation</seealso>
        CreateCaseResponse CreateCase(CreateCaseRequest request);



        /// <summary>
        /// Creates a case in the specified Cases domain. Case system and custom fields are taken
        /// as an array id/value pairs with a declared data types.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>customer_id</code> is a required field when creating a case.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCase">REST API Reference for CreateCase Operation</seealso>
        Task<CreateCaseResponse> CreateCaseAsync(CreateCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a domain, which is a container for all case data, such as cases, fields, templates
        /// and layouts. Each Amazon Connect instance can be associated with only one Cases domain.
        /// 
        ///  <important> 
        /// <para>
        /// This will not associate your connect instance to Cases domain. Instead, use the Amazon
        /// Connect <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateIntegrationAssociation.html">CreateIntegrationAssociation</a>
        /// API.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);



        /// <summary>
        /// Creates a domain, which is a container for all case data, such as cases, fields, templates
        /// and layouts. Each Amazon Connect instance can be associated with only one Cases domain.
        /// 
        ///  <important> 
        /// <para>
        /// This will not associate your connect instance to Cases domain. Instead, use the Amazon
        /// Connect <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateIntegrationAssociation.html">CreateIntegrationAssociation</a>
        /// API.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateField


        /// <summary>
        /// Creates a field in the Cases domain. This field is used to define the case object
        /// model (that is, defines what data can be captured on cases) in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateField service method.</param>
        /// 
        /// <returns>The response from the CreateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateField">REST API Reference for CreateField Operation</seealso>
        CreateFieldResponse CreateField(CreateFieldRequest request);



        /// <summary>
        /// Creates a field in the Cases domain. This field is used to define the case object
        /// model (that is, defines what data can be captured on cases) in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateField">REST API Reference for CreateField Operation</seealso>
        Task<CreateFieldResponse> CreateFieldAsync(CreateFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLayout


        /// <summary>
        /// Creates a layout in the Cases domain. Layouts define the following configuration in
        /// the top section and More Info tab of the Cases user interface:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Fields to display to the users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Field ordering
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts since they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLayout service method.</param>
        /// 
        /// <returns>The response from the CreateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateLayout">REST API Reference for CreateLayout Operation</seealso>
        CreateLayoutResponse CreateLayout(CreateLayoutRequest request);



        /// <summary>
        /// Creates a layout in the Cases domain. Layouts define the following configuration in
        /// the top section and More Info tab of the Cases user interface:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Fields to display to the users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Field ordering
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts since they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateLayout">REST API Reference for CreateLayout Operation</seealso>
        Task<CreateLayoutResponse> CreateLayoutAsync(CreateLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRelatedItem


        /// <summary>
        /// Creates a related item (comments, tasks, and contacts) and associates it with a case.
        /// 
        ///  <note> 
        /// <para>
        /// A Related Item is a resource that is associated with a case. It may or may not have
        /// an external identifier linking it to an external resource (for example, a <code>contactArn</code>).
        /// All Related Items have their own internal identifier, the <code>relatedItemArn</code>.
        /// Examples of related items include <code>comments</code> and <code>contacts</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelatedItem service method.</param>
        /// 
        /// <returns>The response from the CreateRelatedItem service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateRelatedItem">REST API Reference for CreateRelatedItem Operation</seealso>
        CreateRelatedItemResponse CreateRelatedItem(CreateRelatedItemRequest request);



        /// <summary>
        /// Creates a related item (comments, tasks, and contacts) and associates it with a case.
        /// 
        ///  <note> 
        /// <para>
        /// A Related Item is a resource that is associated with a case. It may or may not have
        /// an external identifier linking it to an external resource (for example, a <code>contactArn</code>).
        /// All Related Items have their own internal identifier, the <code>relatedItemArn</code>.
        /// Examples of related items include <code>comments</code> and <code>contacts</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelatedItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelatedItem service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateRelatedItem">REST API Reference for CreateRelatedItem Operation</seealso>
        Task<CreateRelatedItemResponse> CreateRelatedItemAsync(CreateRelatedItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates a template in the Cases domain. This template is used to define the case object
        /// model (that is, define what data can be captured on cases) in a Cases domain. A template
        /// must have a unique name within a domain, and it must reference existing field IDs
        /// and layout IDs. Additionally, multiple fields with same IDs are not allowed within
        /// the same Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);



        /// <summary>
        /// Creates a template in the Cases domain. This template is used to define the case object
        /// model (that is, define what data can be captured on cases) in a Cases domain. A template
        /// must have a unique name within a domain, and it must reference existing field IDs
        /// and layout IDs. Additionally, multiple fields with same IDs are not allowed within
        /// the same Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCase


        /// <summary>
        /// Returns information about a specific case if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCase">REST API Reference for GetCase Operation</seealso>
        GetCaseResponse GetCase(GetCaseRequest request);



        /// <summary>
        /// Returns information about a specific case if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCase">REST API Reference for GetCase Operation</seealso>
        Task<GetCaseResponse> GetCaseAsync(GetCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCaseEventConfiguration


        /// <summary>
        /// Returns the case event publishing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseEventConfiguration">REST API Reference for GetCaseEventConfiguration Operation</seealso>
        GetCaseEventConfigurationResponse GetCaseEventConfiguration(GetCaseEventConfigurationRequest request);



        /// <summary>
        /// Returns the case event publishing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseEventConfiguration">REST API Reference for GetCaseEventConfiguration Operation</seealso>
        Task<GetCaseEventConfigurationResponse> GetCaseEventConfigurationAsync(GetCaseEventConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Returns information about a specific domain if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse GetDomain(GetDomainRequest request);



        /// <summary>
        /// Returns information about a specific domain if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLayout


        /// <summary>
        /// Returns the details for the requested layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayout service method.</param>
        /// 
        /// <returns>The response from the GetLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetLayout">REST API Reference for GetLayout Operation</seealso>
        GetLayoutResponse GetLayout(GetLayoutRequest request);



        /// <summary>
        /// Returns the details for the requested layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetLayout">REST API Reference for GetLayout Operation</seealso>
        Task<GetLayoutResponse> GetLayoutAsync(GetLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Returns the details for the requested template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse GetTemplate(GetTemplateRequest request);



        /// <summary>
        /// Returns the details for the requested template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCasesForContact


        /// <summary>
        /// Lists cases for a given contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCasesForContact service method.</param>
        /// 
        /// <returns>The response from the ListCasesForContact service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCasesForContact">REST API Reference for ListCasesForContact Operation</seealso>
        ListCasesForContactResponse ListCasesForContact(ListCasesForContactRequest request);



        /// <summary>
        /// Lists cases for a given contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCasesForContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCasesForContact service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCasesForContact">REST API Reference for ListCasesForContact Operation</seealso>
        Task<ListCasesForContactResponse> ListCasesForContactAsync(ListCasesForContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Lists all cases domains in the Amazon Web Services account. Each list item is a condensed
        /// summary object of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);



        /// <summary>
        /// Lists all cases domains in the Amazon Web Services account. Each list item is a condensed
        /// summary object of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFieldOptions


        /// <summary>
        /// Lists all of the field options for a field identifier in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldOptions service method.</param>
        /// 
        /// <returns>The response from the ListFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFieldOptions">REST API Reference for ListFieldOptions Operation</seealso>
        ListFieldOptionsResponse ListFieldOptions(ListFieldOptionsRequest request);



        /// <summary>
        /// Lists all of the field options for a field identifier in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFieldOptions">REST API Reference for ListFieldOptions Operation</seealso>
        Task<ListFieldOptionsResponse> ListFieldOptionsAsync(ListFieldOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFields


        /// <summary>
        /// Lists all fields in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFields service method.</param>
        /// 
        /// <returns>The response from the ListFields service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFields">REST API Reference for ListFields Operation</seealso>
        ListFieldsResponse ListFields(ListFieldsRequest request);



        /// <summary>
        /// Lists all fields in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFields service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFields service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFields">REST API Reference for ListFields Operation</seealso>
        Task<ListFieldsResponse> ListFieldsAsync(ListFieldsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLayouts


        /// <summary>
        /// Lists all layouts in the given cases domain. Each list item is a condensed summary
        /// object of the layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayouts service method.</param>
        /// 
        /// <returns>The response from the ListLayouts service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListLayouts">REST API Reference for ListLayouts Operation</seealso>
        ListLayoutsResponse ListLayouts(ListLayoutsRequest request);



        /// <summary>
        /// Lists all layouts in the given cases domain. Each list item is a condensed summary
        /// object of the layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayouts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLayouts service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListLayouts">REST API Reference for ListLayouts Operation</seealso>
        Task<ListLayoutsResponse> ListLayoutsAsync(ListLayoutsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists all of the templates in a Cases domain. Each list item is a condensed summary
        /// object of the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);



        /// <summary>
        /// Lists all of the templates in a Cases domain. Each list item is a condensed summary
        /// object of the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutCaseEventConfiguration


        /// <summary>
        /// API for adding case event publishing configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCaseEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/PutCaseEventConfiguration">REST API Reference for PutCaseEventConfiguration Operation</seealso>
        PutCaseEventConfigurationResponse PutCaseEventConfiguration(PutCaseEventConfigurationRequest request);



        /// <summary>
        /// API for adding case event publishing configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCaseEventConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/PutCaseEventConfiguration">REST API Reference for PutCaseEventConfiguration Operation</seealso>
        Task<PutCaseEventConfigurationResponse> PutCaseEventConfigurationAsync(PutCaseEventConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchCases


        /// <summary>
        /// Searches for cases within their associated Cases domain. Search results are returned
        /// as a paginated list of abridged case documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCases service method.</param>
        /// 
        /// <returns>The response from the SearchCases service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchCases">REST API Reference for SearchCases Operation</seealso>
        SearchCasesResponse SearchCases(SearchCasesRequest request);



        /// <summary>
        /// Searches for cases within their associated Cases domain. Search results are returned
        /// as a paginated list of abridged case documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchCases service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchCases">REST API Reference for SearchCases Operation</seealso>
        Task<SearchCasesResponse> SearchCasesAsync(SearchCasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchRelatedItems


        /// <summary>
        /// Searches for related items that are associated with a case.
        /// 
        ///  <note> 
        /// <para>
        /// If no filters are provided, this returns all related items associated with a case.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelatedItems service method.</param>
        /// 
        /// <returns>The response from the SearchRelatedItems service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchRelatedItems">REST API Reference for SearchRelatedItems Operation</seealso>
        SearchRelatedItemsResponse SearchRelatedItems(SearchRelatedItemsRequest request);



        /// <summary>
        /// Searches for related items that are associated with a case.
        /// 
        ///  <note> 
        /// <para>
        /// If no filters are provided, this returns all related items associated with a case.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchRelatedItems service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchRelatedItems">REST API Reference for SearchRelatedItems Operation</seealso>
        Task<SearchRelatedItemsResponse> SearchRelatedItemsAsync(SearchRelatedItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCase


        /// <summary>
        /// Updates the values of fields on a case. Fields to be updated are received as an array
        /// of id/value pairs identical to the <code>CreateCase</code> input .
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        UpdateCaseResponse UpdateCase(UpdateCaseRequest request);



        /// <summary>
        /// Updates the values of fields on a case. Fields to be updated are received as an array
        /// of id/value pairs identical to the <code>CreateCase</code> input .
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        Task<UpdateCaseResponse> UpdateCaseAsync(UpdateCaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateField


        /// <summary>
        /// Updates the properties of an existing field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateField service method.</param>
        /// 
        /// <returns>The response from the UpdateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateField">REST API Reference for UpdateField Operation</seealso>
        UpdateFieldResponse UpdateField(UpdateFieldRequest request);



        /// <summary>
        /// Updates the properties of an existing field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateField service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateField">REST API Reference for UpdateField Operation</seealso>
        Task<UpdateFieldResponse> UpdateFieldAsync(UpdateFieldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLayout


        /// <summary>
        /// Updates the attributes of an existing layout.
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        ///  
        /// <para>
        /// A <code>ValidationException</code> is returned when you add non-existent <code>fieldIds</code>
        /// to a layout.
        /// </para>
        ///  <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts because they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayout service method.</param>
        /// 
        /// <returns>The response from the UpdateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateLayout">REST API Reference for UpdateLayout Operation</seealso>
        UpdateLayoutResponse UpdateLayout(UpdateLayoutRequest request);



        /// <summary>
        /// Updates the attributes of an existing layout.
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        ///  
        /// <para>
        /// A <code>ValidationException</code> is returned when you add non-existent <code>fieldIds</code>
        /// to a layout.
        /// </para>
        ///  <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts because they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayout service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateLayout">REST API Reference for UpdateLayout Operation</seealso>
        Task<UpdateLayoutResponse> UpdateLayoutAsync(UpdateLayoutRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Updates the attributes of an existing template. The template attributes that can be
        /// modified include <code>name</code>, <code>description</code>, <code>layouts</code>,
        /// and <code>requiredFields</code>. At least one of these attributes must not be null.
        /// If a null value is provided for a given attribute, that attribute is ignored and its
        /// current value is preserved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);



        /// <summary>
        /// Updates the attributes of an existing template. The template attributes that can be
        /// modified include <code>name</code>, <code>description</code>, <code>layouts</code>,
        /// and <code>requiredFields</code>. At least one of these attributes must not be null.
        /// If a null value is provided for a given attribute, that attribute is ignored and its
        /// current value is preserved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
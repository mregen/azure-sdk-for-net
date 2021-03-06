// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// JobOperations operations.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Gets lifetime summary statistics for all of the jobs in the
        /// specified account.
        /// </summary>
        /// <remarks>
        /// Statistics are aggregated across all jobs that have ever existed in
        /// the account, from account creation to the last update time of the
        /// statistics.
        /// </remarks>
        /// <param name='jobGetAllLifetimeStatisticsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<JobStatistics,JobGetAllLifetimeStatisticsHeaders>> GetAllLifetimeStatisticsWithHttpMessagesAsync(JobGetAllLifetimeStatisticsOptions jobGetAllLifetimeStatisticsOptions = default(JobGetAllLifetimeStatisticsOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <remarks>
        /// Deleting a job also deletes all tasks that are part of that job,
        /// and all job statistics. This also overrides the retention period
        /// for task data; that is, if the job contains tasks which are still
        /// retained on compute nodes, the Batch services deletes those tasks'
        /// working directories and all their contents.  When a Delete Job
        /// request is received, the Batch service sets the job to the deleting
        /// state. All update operations on a job that is in deleting state
        /// will fail with status code 409 (Conflict), with additional
        /// information indicating that the job is being deleted.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to delete.
        /// </param>
        /// <param name='jobDeleteOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobDeleteHeaders>> DeleteWithHttpMessagesAsync(string jobId, JobDeleteOptions jobDeleteOptions = default(JobDeleteOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the specified job.
        /// </summary>
        /// <param name='jobId'>
        /// The ID of the job.
        /// </param>
        /// <param name='jobGetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CloudJob,JobGetHeaders>> GetWithHttpMessagesAsync(string jobId, JobGetOptions jobGetOptions = default(JobGetOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the properties of the specified job.
        /// </summary>
        /// <remarks>
        /// This replaces only the job properties specified in the request. For
        /// example, if the job has constraints, and a request does not specify
        /// the constraints element, then the job keeps the existing
        /// constraints.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job whose properties you want to update.
        /// </param>
        /// <param name='jobPatchParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='jobPatchOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobPatchHeaders>> PatchWithHttpMessagesAsync(string jobId, JobPatchParameter jobPatchParameter, JobPatchOptions jobPatchOptions = default(JobPatchOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the properties of the specified job.
        /// </summary>
        /// <remarks>
        /// This fully replaces all the updateable properties of the job. For
        /// example, if the job has constraints associated with it and if
        /// constraints is not specified with this request, then the Batch
        /// service will remove the existing constraints.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job whose properties you want to update.
        /// </param>
        /// <param name='jobUpdateParameter'>
        /// The parameters for the request.
        /// </param>
        /// <param name='jobUpdateOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobUpdateHeaders>> UpdateWithHttpMessagesAsync(string jobId, JobUpdateParameter jobUpdateParameter, JobUpdateOptions jobUpdateOptions = default(JobUpdateOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disables the specified job, preventing new tasks from running.
        /// </summary>
        /// <remarks>
        /// The Batch Service immediately moves the job to the disabling state.
        /// Batch then uses the disableTasks parameter to determine what to do
        /// with the currently running tasks of the job. The job remains in the
        /// disabling state until the disable operation is completed and all
        /// tasks have been dealt with according to the disableTasks option;
        /// the job then moves to the disabled state. No new tasks are started
        /// under the job until it moves back to active state. If you try to
        /// disable a job that is in any state other than active, disabling, or
        /// disabled, the request fails with status code 409.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to disable.
        /// </param>
        /// <param name='disableTasks'>
        /// What to do with active tasks associated with the job. Possible
        /// values include: 'requeue', 'terminate', 'wait'
        /// </param>
        /// <param name='jobDisableOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobDisableHeaders>> DisableWithHttpMessagesAsync(string jobId, DisableJobOption disableTasks, JobDisableOptions jobDisableOptions = default(JobDisableOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables the specified job, allowing new tasks to run.
        /// </summary>
        /// <remarks>
        /// When you call this API, the Batch service sets a disabled job to
        /// the enabling state. After the this operation is completed, the job
        /// moves to the active state, and scheduling of new tasks under the
        /// job resumes. The Batch service does not allow a task to remain in
        /// the active state for more than 7 days. Therefore, if you enable a
        /// job containing active tasks which were added more than 7 days ago,
        /// those tasks will not run.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to enable.
        /// </param>
        /// <param name='jobEnableOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobEnableHeaders>> EnableWithHttpMessagesAsync(string jobId, JobEnableOptions jobEnableOptions = default(JobEnableOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Terminates the specified job, marking it as completed.
        /// </summary>
        /// <remarks>
        /// When a Terminate Job request is received, the Batch service sets
        /// the job to the terminating state. The Batch service then terminates
        /// any active or running tasks associated with the job, and runs any
        /// required Job Release tasks. The job then moves into the completed
        /// state.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job to terminate.
        /// </param>
        /// <param name='terminateReason'>
        /// The text you want to appear as the job's TerminateReason. The
        /// default is 'UserTerminate'.
        /// </param>
        /// <param name='jobTerminateOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobTerminateHeaders>> TerminateWithHttpMessagesAsync(string jobId, string terminateReason = default(string), JobTerminateOptions jobTerminateOptions = default(JobTerminateOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a job to the specified account.
        /// </summary>
        /// <remarks>
        /// The Batch service supports two ways to control the work done as
        /// part of a job. In the first approach, the user specifies a Job
        /// Manager task. The Batch service launches this task when it is ready
        /// to start the job. The Job Manager task controls all other tasks
        /// that run under this job, by using the Task APIs. In the second
        /// approach, the user directly controls the execution of tasks under
        /// an active job, by using the Task APIs. Also note: when naming jobs,
        /// avoid including sensitive information such as user names or secret
        /// project names. This information may appear in telemetry logs
        /// accessible to Microsoft Support engineers.
        /// </remarks>
        /// <param name='job'>
        /// The job to be added.
        /// </param>
        /// <param name='jobAddOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<JobAddHeaders>> AddWithHttpMessagesAsync(JobAddParameter job, JobAddOptions jobAddOptions = default(JobAddOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the jobs in the specified account.
        /// </summary>
        /// <param name='jobListOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CloudJob>,JobListHeaders>> ListWithHttpMessagesAsync(JobListOptions jobListOptions = default(JobListOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the jobs that have been created under the specified job
        /// schedule.
        /// </summary>
        /// <param name='jobScheduleId'>
        /// The ID of the job schedule from which you want to get a list of
        /// jobs.
        /// </param>
        /// <param name='jobListFromJobScheduleOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CloudJob>,JobListFromJobScheduleHeaders>> ListFromJobScheduleWithHttpMessagesAsync(string jobScheduleId, JobListFromJobScheduleOptions jobListFromJobScheduleOptions = default(JobListFromJobScheduleOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the execution status of the Job Preparation and Job Release
        /// task for the specified job across the compute nodes where the job
        /// has run.
        /// </summary>
        /// <remarks>
        /// This API returns the Job Preparation and Job Release task status on
        /// all compute nodes that have run the Job Preparation or Job Release
        /// task. This includes nodes which have since been removed from the
        /// pool. If this API is invoked on a job which has no Job Preparation
        /// or Job Release task, the Batch service returns HTTP status code 409
        /// (Conflict) with an error code of JobPreparationTaskNotSpecified.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job.
        /// </param>
        /// <param name='jobListPreparationAndReleaseTaskStatusOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobPreparationAndReleaseTaskExecutionInformation>,JobListPreparationAndReleaseTaskStatusHeaders>> ListPreparationAndReleaseTaskStatusWithHttpMessagesAsync(string jobId, JobListPreparationAndReleaseTaskStatusOptions jobListPreparationAndReleaseTaskStatusOptions = default(JobListPreparationAndReleaseTaskStatusOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the task counts for the specified job.
        /// </summary>
        /// <remarks>
        /// Task counts provide a count of the tasks by active, running or
        /// completed task state, and a count of tasks which succeeded or
        /// failed. Tasks in the preparing state are counted as running. If the
        /// validationStatus is unvalidated, then the Batch service has not
        /// been able to check state counts against the task states as reported
        /// in the List Tasks API. The validationStatus may be unvalidated if
        /// the job contains more than 200,000 tasks.
        /// </remarks>
        /// <param name='jobId'>
        /// The ID of the job.
        /// </param>
        /// <param name='jobGetTaskCountsOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TaskCounts,JobGetTaskCountsHeaders>> GetTaskCountsWithHttpMessagesAsync(string jobId, JobGetTaskCountsOptions jobGetTaskCountsOptions = default(JobGetTaskCountsOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the jobs in the specified account.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='jobListNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CloudJob>,JobListHeaders>> ListNextWithHttpMessagesAsync(string nextPageLink, JobListNextOptions jobListNextOptions = default(JobListNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the jobs that have been created under the specified job
        /// schedule.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='jobListFromJobScheduleNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<CloudJob>,JobListFromJobScheduleHeaders>> ListFromJobScheduleNextWithHttpMessagesAsync(string nextPageLink, JobListFromJobScheduleNextOptions jobListFromJobScheduleNextOptions = default(JobListFromJobScheduleNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the execution status of the Job Preparation and Job Release
        /// task for the specified job across the compute nodes where the job
        /// has run.
        /// </summary>
        /// <remarks>
        /// This API returns the Job Preparation and Job Release task status on
        /// all compute nodes that have run the Job Preparation or Job Release
        /// task. This includes nodes which have since been removed from the
        /// pool. If this API is invoked on a job which has no Job Preparation
        /// or Job Release task, the Batch service returns HTTP status code 409
        /// (Conflict) with an error code of JobPreparationTaskNotSpecified.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='jobListPreparationAndReleaseTaskStatusNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<JobPreparationAndReleaseTaskExecutionInformation>,JobListPreparationAndReleaseTaskStatusHeaders>> ListPreparationAndReleaseTaskStatusNextWithHttpMessagesAsync(string nextPageLink, JobListPreparationAndReleaseTaskStatusNextOptions jobListPreparationAndReleaseTaskStatusNextOptions = default(JobListPreparationAndReleaseTaskStatusNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

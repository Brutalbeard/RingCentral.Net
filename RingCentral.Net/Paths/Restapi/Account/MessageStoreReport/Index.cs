using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.MessageStoreReport
{
    public partial class Index
    {
        public RestClient rc;
        public string taskId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string taskId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.taskId = taskId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && taskId != null)
            {
                return $"{parent.Path()}/message-store-report/{taskId}";
            }

            return $"{parent.Path()}/message-store-report";
        }

        /// <summary>
        /// Operation: Create Message Store Report
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-report
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Post(
            RingCentral.CreateMessageStoreReportRequest createMessageStoreReportRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.MessageStoreReport>(this.Path(false), createMessageStoreReportRequest,
                null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Message Store Report Task
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/message-store-report/{taskId}
        /// Rate Limit Group: Heavy
        /// App Permission: ReadMessages
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.MessageStoreReport> Get(CancellationToken? cancellationToken = null)
        {
            if (this.taskId == null)
            {
                throw new System.ArgumentNullException("taskId");
            }

            return await rc.Get<RingCentral.MessageStoreReport>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MessageStoreReport.Index MessageStoreReport(string taskId = null)
        {
            return new Restapi.Account.MessageStoreReport.Index(this, taskId);
        }
    }
}
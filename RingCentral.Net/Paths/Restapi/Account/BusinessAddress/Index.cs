using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.BusinessAddress
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/business-address";
        }

        /// <summary>
        /// Operation: Get Account Business Address
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/business-address
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.AccountBusinessAddressResource> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AccountBusinessAddressResource>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Company Business Address
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/business-address
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyInfo
        /// </summary>
        public async Task<RingCentral.AccountBusinessAddressResource> Put(
            RingCentral.ModifyAccountBusinessAddressRequest modifyAccountBusinessAddressRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Put<RingCentral.AccountBusinessAddressResource>(this.Path(),
                modifyAccountBusinessAddressRequest, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.BusinessAddress.Index BusinessAddress()
        {
            return new Restapi.Account.BusinessAddress.Index(this);
        }
    }
}
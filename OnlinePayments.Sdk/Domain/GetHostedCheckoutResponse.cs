/*
 * This class was auto-generated.
 */
namespace OnlinePayments.Sdk.Domain
{
    public class GetHostedCheckoutResponse
    {
        /// <summary>
        /// This object will return the details of the payment after the payment is cancelled by the customer, rejected or authorized<para />
        /// </summary>
        public CreatedPaymentOutput CreatedPaymentOutput { get; set; } = null;

        /// <summary>
        /// This is the status of the hosted checkout. Possible values are:<para />
        /// * IN_PROGRESS - The checkout is still in progress and has not finished yet<para />
        /// * PAYMENT_CREATED - A payment has been created<para />
        /// * CANCELLED_BY_CONSUMER - The HostedCheckout session have been cancelled by the customer<para />
        /// </summary>
        public string Status { get; set; } = null;
    }
}

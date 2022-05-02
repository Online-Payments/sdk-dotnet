/*
 * This class was auto-generated.
 */
namespace OnlinePayments.Sdk.Domain
{
    public class ThreeDSecureResults
    {
        /// <summary>
        /// Authenticated Transaction Identifier at the ACS/Issuer.<para />
        /// </summary>
        public string AcsTransactionId { get; set; } = null;

        /// <summary>
        /// Exemption requested and applied in the authorization<para />
        /// </summary>
        public string AppliedExemption { get; set; } = null;

        /// <summary>
        /// One-letter authentication status returned by DS. Possible values are:<para />
        /// * Y - Authentication succeeded<para />
        /// * A - Authentication attempted<para />
        /// * I - Information only, liability shifted to the merchant<para />
        /// * N - Authentication failed<para />
        /// * R - Authentication rejected<para />
        /// * U - Authentication unavailable<para />
        /// * C - Authentication required<para />
        /// </summary>
        public string AuthenticationStatus { get; set; } = null;

        /// <summary>
        /// Cardholder Authentication Verification Value. End-2-end reference generated by the Issuer to recognize that the authentication has taken place.<para />
        /// </summary>
        public string Cavv { get; set; } = null;

        /// <summary>
        /// Challenge Indicator used for this transaction. This value might differ from the one sent by the merchant if the card is not supporting it (3DS version 2.1 vs 3DS version 2.2).<para />
        /// </summary>
        public string ChallengeIndicator { get; set; } = null;

        /// <summary>
        /// 3D Secure Directory Server Transaction Identifier used for this transaction.<para />
        /// </summary>
        public string DsTransactionId { get; set; } = null;

        /// <summary>
        /// Indicates Authentication validation results returned after AuthenticationValidation<para />
        /// </summary>
        public string Eci { get; set; } = null;

        /// <summary>
        /// 3D Secure Flow used during this transaction.<para />
        /// </summary>
        public string Flow { get; set; } = null;

        /// <summary>
        /// Determines the Fraud liability. Possible values are:<para />
        /// * issuer - Fraud liability shifts to the issuer<para />
        /// * merchant - Fraud liability with the merchant <para />
        /// <para />
        /// Note: When not filled in Fraud liability is not applicable for the current transaction.<para />
        /// </summary>
        public string Liability { get; set; } = null;

        /// <summary>
        /// 3D Secure ECI (Electronic Commerce Indicator) depending on the Scheme. Returned by DS.<para />
        /// </summary>
        public string SchemeEci { get; set; } = null;

        /// <summary>
        /// 3D Secure Protocol version used during this transaction.<para />
        /// </summary>
        public string Version { get; set; } = null;

        /// <summary>
        /// Transaction ID for the Authentication<para />
        /// </summary>
        public string Xid { get; set; } = null;
    }
}

// This class was generated on Wed, 13 Dec 2017 14:32:17 CST by version 0.1 of Braintree SDK Generator
// Invoice.cs
// @version 0.1
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Invoice details.
    /// </summary>
    [DataContract]
    public class Invoice {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Invoice() {}

        /// <summary>
        /// Indicates whether the invoice allows a partial payment. If `false`, invoice must be paid in full. If `true`, the invoice allows partial payments.
        /// </summary>
        [DataMember(Name="allow_partial_payment", EmitDefaultValue = false)]
        public bool AllowPartialPayment { get; set; }

        /// <summary>
        /// Indicates whether the invoice enables the customer to enter a tip amount during payment. If `true`, the invoice shows a tip amount field so that the customer can enter a tip amount. If `false`, the invoice does not show a tip amount field.
        /// </summary>
        [DataMember(Name="allow_tip", EmitDefaultValue = false)]
        public bool AllowTip { get; set; }

        /// <summary>
        /// List of files that are attached to the invoice.
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue = false)]
        public List<FileAttachment> Attachments { get; set; }

        /// <summary>
        /// The required invoice recipient email address and any optional billing information. Supports only one recipient.
        /// </summary>
        [DataMember(Name="billing_info", EmitDefaultValue = false)]
        public List<BillingInfo> BillingInfo { get; set; }

        /// <summary>
        /// For invoices sent by email, one or more email addresses to which to send a CC: copy of the notification. Supports only email addresses under participant.
        /// </summary>
        [DataMember(Name="cc_info", EmitDefaultValue = false)]
        public List<Participant> CcInfo { get; set; }

        /// <summary>
        /// The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
        /// </summary>
        [DataMember(Name="custom", EmitDefaultValue = false)]
        public CustomAmount Custom { get; set; }

        /// <summary>
        /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue = false)]
        public Cost Discount { get; set; }

        /// <summary>
        /// The ID of the invoice.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The date when the invoice was enabled. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// The items to include in the invoice. An invoice can contain a maximum of 100 items.
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue = false)]
        public List<InvoiceItem> Items { get; set; }

        /// <summary>
        /// The HATEOAS links that provide related actions for the invoice based on the current invoice status.
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links { get; set; }

        /// <summary>
        /// The full URL to an external logo image.
        /// </summary>
        [DataMember(Name="logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// REQUIRED
        /// Merchant business information that appears on the invoice.
        /// </summary>
        [DataMember(Name="merchant_info", EmitDefaultValue = false)]
        public MerchantInformation MerchantInfo { get; set; }

        /// <summary>
        /// A private bookkeeping memo for the merchant.
        /// </summary>
        [DataMember(Name="merchant_memo", EmitDefaultValue = false)]
        public string MerchantMemo { get; set; }

        /// <summary>
        /// Audit information for the resource.
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue = false)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="minimum_amount_due", EmitDefaultValue = false)]
        public Currency MinimumAmountDue { get; set; }

        /// <summary>
        /// A note to the payer.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The unique invoice number. If you omit this number, it is auto-incremented from the previous invoice number.
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// The payment and refund summary.
        /// </summary>
        [DataMember(Name="paid_amount", EmitDefaultValue = false)]
        public PaymentSummary PaidAmount { get; set; }

        /// <summary>
        /// The payment term of the invoice. If you specify `term_type`, you cannot specify `due_date`, and vice versa.
        /// </summary>
        [DataMember(Name="payment_term", EmitDefaultValue = false)]
        public PaymentTerm PaymentTerm { get; set; }

        /// <summary>
        /// List of payment details for the invoice.
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue = false)]
        public List<PaymentDetail> Payments { get; set; }

        /// <summary>
        /// Reference data, such as PO number, to add to the invoice.
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// The payment and refund summary.
        /// </summary>
        [DataMember(Name="refunded_amount", EmitDefaultValue = false)]
        public PaymentSummary RefundedAmount { get; set; }

        /// <summary>
        /// List of refund details for the invoice.
        /// </summary>
        [DataMember(Name="refunds", EmitDefaultValue = false)]
        public List<RefundDetail> Refunds { get; set; }

        /// <summary>
        /// The shipping cost, as a percentage or amount value.
        /// </summary>
        [DataMember(Name="shipping_cost", EmitDefaultValue = false)]
        public ShippingCost ShippingCost { get; set; }

        /// <summary>
        /// The shipping information for the invoice recipient.
        /// </summary>
        [DataMember(Name="shipping_info", EmitDefaultValue = false)]
        public ShippingInfo ShippingInfo { get; set; }

        /// <summary>
        /// The invoice status. When you [search for invoices](/docs/api/invoicing/#invoices_search), you must specify this value as an array. For example, `"status": ["REFUNDED"]`.
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the tax is calculated before or after a discount. If `false`, the tax is calculated before a discount. If `true`, the tax is calculated after a discount.
        /// </summary>
        [DataMember(Name="tax_calculated_after_discount", EmitDefaultValue = false)]
        public bool TaxCalculatedAfterDiscount { get; set; }

        /// <summary>
        /// Indicates whether the unit price includes tax.
        /// </summary>
        [DataMember(Name="tax_inclusive", EmitDefaultValue = false)]
        public bool TaxInclusive { get; set; }

        /// <summary>
        /// The ID of the template from which to create the invoice. Useful for copy functionality.
        /// </summary>
        [DataMember(Name="template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The general terms of the invoice.
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue = false)]
        public string Terms { get; set; }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="total_amount", EmitDefaultValue = false)]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// The URI of the invoice.
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue = false)]
        public string Uri { get; set; }
    }
}


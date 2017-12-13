// This class was generated on Wed, 13 Dec 2017 14:32:23 CST by version 0.1 of Braintree SDK Generator
// PaymentDetail.cs
// @version 0.1
// @type object
// @data H4sIAAAAAAAC/7xVXW/bOBB8v1+xUF4SQZbuzveB+s2tUyBAkxipUbQIjGRNrmy2FMmSqxhqkf9eSLJlJ3bRFDHyJpCz5Mwsd/Q9mlSOokE0xqogwzAiRqWjJPqAXuFM0wUW9X6URCMKwivHypqtAtkUhDRKoqH3WLXn/ZlEV4Ty0ugqGuSoA9ULX0vlSXYLY28deVYUosF1x+RN6T0ZUe1ywMKWhneYvMZAYGefSTDk1gNqDbkyaIRCDXeoSwJPGpkk5Iq0DHA8Q41GUAJuLaOkBIhFenIwIYG9MvNdGWIj8KGQPmhiJg9rBAgrCTCApFwZkjCr4Oz9Jfzz91///5bh7MtHNE2p9X3yS66NeztE20ZA6YAtXIBUc8WAeU2dFwSShCpQBwjk0CPXPdloUKbT0LSrrkDnvHVeIdND8YdQOX2CTom8K3NSa6kpLRdkGp7K3FklCJYYwKGSKXSY3PoCGVSAuKqqKu7F5+dxL5YyhvhbnDxy4PrMMHlDDCNkyiaqIHjbnDA9XjC7QZaxtTqkijhPrZ9nCy505nPR7/dfHQUSNcfev+l/J8+dvCe+hIJ4YeVej9YzVNSv1XpooSmsr4Wl4kXj3+3px8np1cXw3W1XxJWjl3nLxu7p8WXzgTqFIdQAwBCsUE1YdLRXXF/IafZoAjYNvlH7HT8btUkHY6zGqDdmbkr32j8efho/y/zDqKqv3atrC/Si3H7GZ9unemzRrCJAmTnk2i7bALj2JKyX4CkvjZweZ9KKkKFTWYfOjlbZEW5acK8Fn6ymBULpnPUcHs9JC2vdaC7rmri1U8fO6oD6J2c9zFB8WaKXIGzhkNVMacXVQfyc3v/xAwAA//8=
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.Invoices
{
    /// <summary>
    /// Payment details.
    /// </summary>
    [DataContract]
    public class PaymentDetail {

        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentDetail() {}

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Currency Amount { get; set; }

        /// <summary>
        /// The date when the invoice was paid. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// REQUIRED
        /// The payment mode or method. Required with the `EXTERNAL` payment type.
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Optional. A note associated with the payment.
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// The ID for a PayPal payment transaction. Required with the `PAYPAL` payment type.
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The transaction type.
        /// </summary>
        [DataMember(Name="transaction_type", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The payment type in an invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue = false)]
        public string Type { get; set; }
    }
}


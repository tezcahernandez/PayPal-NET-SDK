using Newtonsoft.Json;

namespace PayPal.Api.Payments
{
    public class PaymentOptions
    {
        /// <summary>
        /// Payment method requested for this purchase unit
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowed_payment_method")]
        public string allowed_payment_method { get; set; }

        /// <summary>
        /// Converts the object to JSON string
        /// </summary>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}

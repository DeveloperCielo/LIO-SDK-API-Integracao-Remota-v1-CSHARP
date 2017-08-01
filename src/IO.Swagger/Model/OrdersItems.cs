/* 
 * LIO - Order Management API
 *
 * API de gerenciamento de pedidos da LIO.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OrdersItems
    /// </summary>
    [DataContract]
    public partial class OrdersItems :  IEquatable<OrdersItems>, IValidatableObject
    {
        /// <summary>
        /// Unidade de medida.
        /// </summary>
        /// <value>Unidade de medida.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum EACH for "EACH"
            /// </summary>
            [EnumMember(Value = "EACH")]
            EACH,
            
            /// <summary>
            /// Enum HOURS for "HOURS"
            /// </summary>
            [EnumMember(Value = "HOURS")]
            HOURS,
            
            /// <summary>
            /// Enum DAYS for "DAYS"
            /// </summary>
            [EnumMember(Value = "DAYS")]
            DAYS,
            
            /// <summary>
            /// Enum SECONDS for "SECONDS"
            /// </summary>
            [EnumMember(Value = "SECONDS")]
            SECONDS,
            
            /// <summary>
            /// Enum CRATEOF12 for "CRATE_OF_12"
            /// </summary>
            [EnumMember(Value = "CRATE_OF_12")]
            CRATEOF12,
            
            /// <summary>
            /// Enum SIXPACK for "SIX_PACK"
            /// </summary>
            [EnumMember(Value = "SIX_PACK")]
            SIXPACK,
            
            /// <summary>
            /// Enum GALLON for "GALLON"
            /// </summary>
            [EnumMember(Value = "GALLON")]
            GALLON,
            
            /// <summary>
            /// Enum LITRE for "LITRE"
            /// </summary>
            [EnumMember(Value = "LITRE")]
            LITRE
        }

        /// <summary>
        /// Unidade de medida.
        /// </summary>
        /// <value>Unidade de medida.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersItems" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrdersItems() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersItems" /> class.
        /// </summary>
        /// <param name="Sku">SKU do produto - identificação única do produto, preferencialmente usando identificações do mercado para o produto, como: &lt;br&gt; - Universal Product Code (UPC),&lt;br&gt; - International Article Number (EAN),&lt;br&gt; - Global Trade Item Number (GTIN),&lt;br&gt; - Australian Product Number (APN),&lt;br&gt; - Outros.&lt;br&gt; Caso seu produto não tenha uma identificação global, utilize informe um ID único proprietário para esse produto. (required).</param>
        /// <param name="SkuType">Tipo de SKU informado, por exemplo:&lt;br&gt; - PTY - para proprietário - ou seja, quando o SKU for sua identificação proprietária.&lt;br&gt; - UPC - Universal Product Code.&lt;br&gt; - EAN - International Article Number.&lt;br&gt; - GTIN - Global Trade Item Number.&lt;br&gt; - APN - Australian Product Number. (required).</param>
        /// <param name="Name">Nome do produto..</param>
        /// <param name="Description">Descrição do produto..</param>
        /// <param name="UnitPrice">Valor unitário do produto. Exemplo: O valor de R$ 10,00 é representado como 1000. (required).</param>
        /// <param name="Quantity">Quantidade de itens. Caso não seja informado será considerado o valor 1..</param>
        /// <param name="UnitOfMeasure">Unidade de medida. (required).</param>
        /// <param name="Details">Detalhes do produto..</param>
        /// <param name="CreatedAt">Data da criação/inclusão do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) (required).</param>
        /// <param name="UpdatedAt">Data da última atualização do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z) (required).</param>
        public OrdersItems(string Sku = default(string), string SkuType = default(string), string Name = default(string), string Description = default(string), int? UnitPrice = default(int?), int? Quantity = default(int?), UnitOfMeasureEnum? UnitOfMeasure = default(UnitOfMeasureEnum?), string Details = default(string), DateTime? CreatedAt = default(DateTime?), DateTime? UpdatedAt = default(DateTime?))
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for OrdersItems and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "SkuType" is required (not null)
            if (SkuType == null)
            {
                throw new InvalidDataException("SkuType is a required property for OrdersItems and cannot be null");
            }
            else
            {
                this.SkuType = SkuType;
            }
            // to ensure "UnitPrice" is required (not null)
            if (UnitPrice == null)
            {
                throw new InvalidDataException("UnitPrice is a required property for OrdersItems and cannot be null");
            }
            else
            {
                this.UnitPrice = UnitPrice;
            }
            // to ensure "UnitOfMeasure" is required (not null)
            if (UnitOfMeasure == null)
            {
                throw new InvalidDataException("UnitOfMeasure is a required property for OrdersItems and cannot be null");
            }
            else
            {
                this.UnitOfMeasure = UnitOfMeasure;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for OrdersItems and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for OrdersItems and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            this.Name = Name;
            this.Description = Description;
            this.Quantity = Quantity;
            this.Details = Details;
        }
        
        /// <summary>
        /// SKU do produto - identificação única do produto, preferencialmente usando identificações do mercado para o produto, como: &lt;br&gt; - Universal Product Code (UPC),&lt;br&gt; - International Article Number (EAN),&lt;br&gt; - Global Trade Item Number (GTIN),&lt;br&gt; - Australian Product Number (APN),&lt;br&gt; - Outros.&lt;br&gt; Caso seu produto não tenha uma identificação global, utilize informe um ID único proprietário para esse produto.
        /// </summary>
        /// <value>SKU do produto - identificação única do produto, preferencialmente usando identificações do mercado para o produto, como: &lt;br&gt; - Universal Product Code (UPC),&lt;br&gt; - International Article Number (EAN),&lt;br&gt; - Global Trade Item Number (GTIN),&lt;br&gt; - Australian Product Number (APN),&lt;br&gt; - Outros.&lt;br&gt; Caso seu produto não tenha uma identificação global, utilize informe um ID único proprietário para esse produto.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Tipo de SKU informado, por exemplo:&lt;br&gt; - PTY - para proprietário - ou seja, quando o SKU for sua identificação proprietária.&lt;br&gt; - UPC - Universal Product Code.&lt;br&gt; - EAN - International Article Number.&lt;br&gt; - GTIN - Global Trade Item Number.&lt;br&gt; - APN - Australian Product Number.
        /// </summary>
        /// <value>Tipo de SKU informado, por exemplo:&lt;br&gt; - PTY - para proprietário - ou seja, quando o SKU for sua identificação proprietária.&lt;br&gt; - UPC - Universal Product Code.&lt;br&gt; - EAN - International Article Number.&lt;br&gt; - GTIN - Global Trade Item Number.&lt;br&gt; - APN - Australian Product Number.</value>
        [DataMember(Name="skuType", EmitDefaultValue=false)]
        public string SkuType { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        /// <value>Nome do produto.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        /// <value>Descrição do produto.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Valor unitário do produto. Exemplo: O valor de R$ 10,00 é representado como 1000.
        /// </summary>
        /// <value>Valor unitário do produto. Exemplo: O valor de R$ 10,00 é representado como 1000.</value>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public int? UnitPrice { get; set; }

        /// <summary>
        /// Quantidade de itens. Caso não seja informado será considerado o valor 1.
        /// </summary>
        /// <value>Quantidade de itens. Caso não seja informado será considerado o valor 1.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }


        /// <summary>
        /// Detalhes do produto.
        /// </summary>
        /// <value>Detalhes do produto.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Data da criação/inclusão do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)
        /// </summary>
        /// <value>Data da criação/inclusão do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Data da última atualização do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)
        /// </summary>
        /// <value>Data da última atualização do item no pedido. A data deve estar no formato: YYYY-MM-DDThh:mm:ssZ (Exemplo: 20151020T13:13:29.000Z)</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrdersItems {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SkuType: ").Append(SkuType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrdersItems);
        }

        /// <summary>
        /// Returns true if OrdersItems instances are equal
        /// </summary>
        /// <param name="other">Instance of OrdersItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrdersItems other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.SkuType == other.SkuType ||
                    this.SkuType != null &&
                    this.SkuType.Equals(other.SkuType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.UnitOfMeasure == other.UnitOfMeasure ||
                    this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(other.UnitOfMeasure)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.SkuType != null)
                    hash = hash * 59 + this.SkuType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.UnitOfMeasure != null)
                    hash = hash * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
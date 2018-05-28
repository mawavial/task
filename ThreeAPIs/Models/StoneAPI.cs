using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThreeAPIs.Models
{
    public class StoneAPI
    {
        public int ID { get; set; }

        public Guid MerchantKey { get; set; }

        public int CreditCardTransactionCollectionAmountCents { get; set; }

        [StringLength(10, ErrorMessage = "A bandeira não pode ter mais de 10 caracteres")]
        public string CreditCardTransactionCollectionCreditCardCreditCardBrand { get; set; }

        [StringLength(19, ErrorMessage = "O cartão não pode conter mais de 19 numerais")]
        public string CreditCardTransactionCollectionCreditCardCreditCardNumber { get; set; }

        [StringLength(2, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public int CreditCardTransactionCollectionCreditCardExpMonth { get; set; }

        [Range(2, 2, ErrorMessage = "Data inválida")]
        public int CreditCardTransactionCollectionCreditCardExpYear { get; set; }

        [Range(3, 4, ErrorMessage = "Codigo Inválido")]
        public int CreditCardTransactionCollectionCreditCardSecurityCode { get; set; }

        [StringLength(25, ErrorMessage = "Máximo de 25 caracteres")]
        public string CreditCardTransactionCollectionCreditCardHolderName { get; set; }

        [Range(0, 2, ErrorMessage = "Número máximo de parcelas é 2")]
        public int CreditCardTransactionCollectionCreditCardInstallmentCount { get; set; }

        public string OrderOrderReference { get; set; }
    }
}

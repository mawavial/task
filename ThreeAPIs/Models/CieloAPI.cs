using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ThreeAPIs.Models
{
    public class CieloAPI
    {
        public int ID { get; set; }

        public Guid MerchantId { get; set; }

        [StringLength(40, ErrorMessage = "A chave não pode ter mais de 40 caracteres")]
        public string MechantKey { get; set; }

        public Guid RequestId { get; set; }

        [StringLength(50, ErrorMessage = "MerchantId não pode ser maior que 50")]
        public string MerchantOrderId {get;set;}

        [StringLength(255, ErrorMessage = "Usuario não pode ter mais que 255 caracteres")]
        public string CustomerName { get; set; }

        [StringLength(100, ErrorMessage = "Tipo de pagamento não pode ser maior que 100 caracteres")]
        public string PaymentType { get; set; }

        [Range(3, 15, ErrorMessage = "Valor minimo de 1 real")]
        public int PaymentAmount { get; set; }

        [Range(0, 2, ErrorMessage = "Número máximo de parcelas é 2")]
        public int PaymentInstallment { get; set; }

        [StringLength(13, ErrorMessage = "Máximo de 13 caracteres")]
        public int PaymentSoftDescriptor { get; set; }


        [StringLength(19, ErrorMessage = "O cartão não pode conter mais de 19 numerais")]
        public string CrediCardCardNumber { get; set; }

        [StringLength(25, ErrorMessage = "Máximo de 25 caracteres")]
        public string CreditCardHolder { get; set; }

        [Range(3, 4, ErrorMessage = "Codigo Inválido")]
        public int CreditCardSecurityCode { get; set; }

        [StringLength(10, ErrorMessage = "A bandeira não pode ter mais de 10 caracteres")]
        public string CreditCardBrand { get; set; }

    }
}

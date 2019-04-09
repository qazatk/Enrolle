using System;
using System.ComponentModel.DataAnnotations;

/* Международные сертификаты по англискому языку */

namespace QazATK.Models
{
    public class InternationalCertificate
    {
        [Key]
        public int CertificateID { get; internal set; }
        public string CertificateName { get; internal set; }         
    }
}
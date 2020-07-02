using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace M1Shop.ViewModels
{
    public class CarDetailCreateModels
    {
        public int CarDetailId { get; set; }
        public string CarilanTitle { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CarDateTime { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public int CarKm { get; set; }
        public string KasaType { get; set; }
        public string MotorGücü { get; set; }
        public string MotorHacmi { get; set; }
        public string Cekis { get; set; }
        public string Renk { get; set; }
        public Garanti Garanti { get; set; }
        public string Plaka { get; set; }
        public Takas Takas { get; set; }
        public Durum Durum { get; set; }
        public IFormFile Photo { get; set; }
        

    }


    public enum Garanti
    {
        Evet,
        Hayır
    }

    public enum Takas
    {
        Evet,
        Hayır

    }

    public enum Durum
    {
        Sıfır,
        İkinciEl
    }
}





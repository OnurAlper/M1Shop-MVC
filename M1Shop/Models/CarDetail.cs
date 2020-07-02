using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace M1Shop.Models
{
    public class CarDetail
    {
        public int CarDetailId { get; set; }
        public string CarilanTitle { get; set; }
        public  DateTime CarDateTime { get; set; }
        public  string Marka { get; set; }
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
        public string PhotoPath { get; set; }

        [NotMapped]
        public string PhotoPathAddress => "img/" + PhotoPath;

        public string IlanUser { get; set; }

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

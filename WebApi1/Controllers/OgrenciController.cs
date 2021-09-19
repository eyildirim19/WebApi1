using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    public class OgrenciController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(new Ogrenci { Adi = "Kaan", SoyAdi = "Meşe" });
            ogrencis.Add(new Ogrenci { Adi = "Ekrem", SoyAdi = "Yıldırım" });
            ogrencis.Add(new Ogrenci { Adi = "Emre", SoyAdi = "Kayaoğlu" });

            return Ok(ogrencis);
        }

        public IHttpActionResult Post(Ogrenci ogr)
        {
            return Ok("Kaydetme İşlemi Başarılıdır");
        }

    }
}
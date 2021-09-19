using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi1.Controllers
{
    // Api sınıfının metotları dışarıya açık metotlardır. Entegratör olarak buradaki metotlarınıza karşı tarafın uygulamaları erişecektir... Webapi metotları HttpMetotlarıdır. GET,POST,PUT ve DELETE requestler ile çağrılırlar. 


    // Apiler arayüz desteği olmadığı için testlerini yapabilmek adına client uygulamaları kullanılır. Bu uygulamar SOAP UI, Postman, apilerin içerisindeki swagger uygulamarlı kullanılır...Web Apilerimizi test edebilmek için postman uygulamasını indiriyoruz...Linki https://www.postman.com/downloads/
    public class HomeController : ApiController
    {
        // IHttpActionResult => Http formatında result dönmemizi sağlar
        public IHttpActionResult Get()
        {
            //return Ok() => Http Status Code formatında content döner...

            // 200 => Success
            // 400 => BadRequest
            // 500 => Server Error
            // 404 => Not Found

            return Ok("Merhaba Arkadaşlar. Ben bir web apiyim. Benim diğer web uygulamalarından farkım ben arayüz sağlamam. Sadece uygulamara entegra olurum");
        }

        public IHttpActionResult Get(string isim)
        {
            if (isim == "Kaan")
            {
                return Ok("İşlem Başarılı");
            }
            else if (isim == "Öykü")
            {
                return NotFound();
            }
            else if (isim=="Ekrem")
            {
                return InternalServerError();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
using MobilBankApp.DAL.Implementation;
using MobilBankApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobilBankApp.WebApi.Controllers
{
    [Route("api/Hesap")]
    public class HesapController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new HesapRepository())
                {
                    var templist = c.GetAll().ToList();
                    if (templist == null)
                        return NotFound();
                    return Ok(templist);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Get(string tckn)
        {
            try
            {
                using (var c = new HesapRepository())
                {
                    var temp = c.GetAll().Where(s => s.TCKN == tckn).FirstOrDefault();
                    if (temp == null)
                        return NotFound();
                    return Ok(temp);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Post([FromBody]Hesap hesap)
        {
            try
            {
                using (var c = new HesapRepository())
                {
                    if (c.Insert(hesap))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Put([FromBody]Hesap hesap)
        {
            try
            {
                using (var c = new HesapRepository())
                {
                    if (c.Update(hesap))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
    }
}

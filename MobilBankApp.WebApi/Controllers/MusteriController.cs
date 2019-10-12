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
    [Route("api/Musteri")]
    public class MusteriController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new MusteriRepository())
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
                using (var c = new MusteriRepository())
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
        public IHttpActionResult Post([FromBody]Musteri musteri)
        {
            try
            {
                using (var c = new MusteriRepository())
                {
                    if (c.Insert(musteri))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Put([FromBody]Musteri musteri)
        {
            try
            {
                using (var c = new MusteriRepository())
                {
                    if (c.Update(musteri))
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

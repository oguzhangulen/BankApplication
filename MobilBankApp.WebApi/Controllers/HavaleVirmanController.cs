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
    [Route("api/HavaleVirman")]
    public class HavaleVirmanController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new HavaleVirmanRepository())
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
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (var c = new HavaleVirmanRepository())
                {
                    var temp = c.GetAll().Where(s => s.Id == id).FirstOrDefault();
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
        public IHttpActionResult Post([FromBody]HavaleVirman havaleVirman)
        {
            try
            {
                using (var c = new HavaleVirmanRepository())
                {
                    if (c.Insert(havaleVirman))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Put([FromBody]HavaleVirman havaleVirman)
        {
            try
            {
                using (var c = new HavaleVirmanRepository())
                {
                    if (c.Update(havaleVirman))
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

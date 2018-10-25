using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using blogapi.Models;
using Microsoft.AspNetCore.Cors;

namespace blogapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET api/posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostModel>>> Get()
        {
            return await Task.Run<ActionResult<IEnumerable<PostModel>>>( () => 
            {
              return MockData.POSTS;
            });
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public ActionResult<PostModel> Get(int id)
        {
            return new PostModel();
        }

        // POST api/posts
        [HttpPost]
        public void Post([FromBody] PostModel model)
        {

        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PostModel model)
        {
          if (model == null)
            throw new ArgumentNullException(nameof(model));
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

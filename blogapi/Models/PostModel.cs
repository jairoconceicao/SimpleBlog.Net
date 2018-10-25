using System;
using System.Collections.Generic;

namespace blogapi.Models 
{
  [Serializable]
  public class PostModel
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Text { get; set; }
    public string Author { get; set; }
    public DateTime DatePublish { get; set; }
  }
}

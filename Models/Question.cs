using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionAPP.Models
{
  public class Question
  {
    public int Id { get; set; }
    public ICollection<Answer> Answer{ get; set; }
    public string questiontext { get; set; } = string.Empty;
  }
}
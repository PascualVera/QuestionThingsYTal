using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace QuestionAPP.Models
{
  public class User
  {
    public int Id { get; set; }
    public string email { get; set; } = string.Empty;

       
    }
}
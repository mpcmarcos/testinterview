using Interview.Models;
using System.ComponentModel.DataAnnotations;

namespace Interview.Data
{
  public class TwoFields
  {
    public TwoFields() { }

    public TwoFields(TwoFieldsViewModel model)
    {
      Field1 = model.Field1;
      Field2 = model.Field2;
    }

    [Key]
    public int ID { get; set; }

    public string Field1 { get; set; }

    public string Field2 { get; set; }
  }
}

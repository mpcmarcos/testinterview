using Interview.Data;

namespace Interview.Models
{
  public class TwoFieldsViewModel
  {
    public TwoFieldsViewModel() { }

    public TwoFieldsViewModel(TwoFields entity)
    {
      Field1 = entity.Field1;
      Field2 = entity.Field2;
    }

    public string Field1 { get; set; }

    public string Field2 { get; set; }
  }
}

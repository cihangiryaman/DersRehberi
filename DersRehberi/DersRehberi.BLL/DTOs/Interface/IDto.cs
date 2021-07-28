using System.Collections.Generic;

namespace DersRehberi.BLL.DTOs.Interface
{
    public interface IDto<T> where T : class, new()
    {
        int Id { get; set; }
        List<string> ErrorMessages { get; set; }
        bool IsValid { get; set; }
    }
}

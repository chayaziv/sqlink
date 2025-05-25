using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsCore.Utils;

namespace TicketsCore.IServices
{
    public interface IAuthService
    {
        Task<Result<AuthData>> RegisterUserAsync(RegisterModel model);
        Task<Result<AuthData>> LoginAsync(LoginModel model);
    }
}

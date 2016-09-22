using System.Threading.Tasks;
using Abp.Application.Services;
using tigerball.Roles.Dto;

namespace tigerball.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}

using Library1Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace LibraryApp.Permissions
{
    public enum ApplicationPermissions
    {
        [Description("لیست کاربران")]
        User_List=10001,
        User_Delete=10002,
        User_Edit= 10003,
        User_Add= 10004,


        Book_List = 20001,
    }
    public class PermissionManager
    {
        public bool DoesUserHavePermission(int userId, ApplicationPermissions permission)
        {
            using(var repo = new UnitOfWork())
            {
                //select top 1 1 from userpermission where userId = userid and permissionid = poermission
                return repo.UserPermission.GetAllAsQueryable().Any(r => r.UserId == userId && r.PermissionId == (int)permission);
            }
        }
        public void AddPermissionToUser(int userId, int permissionId)
        {

        }
        public void RemovePermissionFromUser(int userId, int permissionId)
        {

        }
    }
}

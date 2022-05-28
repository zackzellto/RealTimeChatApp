using System;

namespace ChatApp.Data
{
    public interface IChatAppDataAccessProvider
    {
        void SendMessage(int messageid, string message, string user, string time);

        void DeleteMessage(string message, string user, string time);

        void AddUser(int userid, string user);

        void DeleteUser(int userid, string user);

        void ChangePassword(string user, string password);


        string[] GetMessages();
        string[] GetUsers();
    }
}
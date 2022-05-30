using System;

namespace ChatApp.Data
{
    public interface IChatAppDataAccessProvider
    {
        void SendMessage(string message, string user, string time);

        void DeleteMessage(int messageid);

        void AddUser(string user);

        void DeleteUser(int userid);


        string[] GetMessages();
        string[] GetUsers();

        string[] GetUserById(int userid);

        string[] GetMessageById(int messageid);
    }
}
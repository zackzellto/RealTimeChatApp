using System;

namespace ChatApp.Data
{
    public class ChatAppAccessProvider : IChatAppDataAccessProvider
    {
        private readonly ChatAppDataContext _context;

        public ChatAppAccessProvider(ChatAppDataContext context)
        {
            _context = context;
        }

        //POST a message api/Messages
        public void SendMessage(string message, string user, string time)
        {
            _context.Messages.Add(new Messages { Message = message, User = user, Time = time });
            _context.SaveChanges();
        }

        //DELTE a message api/Messages/id
        public void DeleteMessage(int messageid)
        {
            var messageToDelete = _context.Messages.Find(messageid);
            _context.Messages.Remove(messageToDelete);
            _context.SaveChanges();
        }

        //POST a user api/Users
        public void AddUser(string user)
        {
            _context.Users.Add(new Users { User = user });
            _context.SaveChanges();
        }

        //DELETE a user api/Users/id
        public void DeleteUser(int userid)
        {
            var userToDelete = _context.Users.Find(userid);
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
        }

        //GET messages api/Messages
        public string[] GetMessages()
        {
            var messages = _context.Messages.ToArray();
            string[] messagesArray = new string[messages.Length];
            for (int i = 0; i < messages.Length; i++)
            {
                messagesArray[i] = messages[i].Message;
            }
            return messagesArray;
        }

        //GET users api/Users
        public string[] GetUsers()
        {
            var users = _context.Users.ToArray();
            string[] usersArray = new string[users.Length];
            for (int i = 0; i < users.Length; i++)
            {
                usersArray[i] = users[i].User;
            }
            return usersArray;
        }

    }
}
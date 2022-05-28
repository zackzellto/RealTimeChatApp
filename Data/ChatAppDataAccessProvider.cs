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

        public void SendMessage(string message, string user, string time)
        {
            _context.Messages.Add(new Messages { Message = message, User = user, Time = time });
            _context.SaveChanges();
        }

        public void DeleteMessage(string message, string user, string time)
        {
            var messageToDelete = _context.Messages.Find(message, user, time);
            _context.Messages.Remove(messageToDelete);
            _context.SaveChanges();
        }

        public void AddUser(string user)
        {
            _context.Users.Add(new Users { User = user });
            _context.SaveChanges();
        }

        public void DeleteUser(int userid, string user)
        {
            var userToDelete = _context.Users.Find(user);
            _context.Users.Remove(userToDelete);
            _context.SaveChanges();
        }

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
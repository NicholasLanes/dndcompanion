using dnd.Models.Characters;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dnd.Models.Session
{
    public static class UserSession
    {
        // Override with Newtonsoft Json to convert objects passed into the session with these methods
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key,JsonConvert.SerializeObject(value));
        }
        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return (value == null) ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
    public class Session
    {
        // Declarations
        private const string SessionKey = "key";
        private const string CharactersKey = "key";
        private ISession session { get; set; }
        // Session declares a Session object and passes value to private session object
        public Session(ISession s)
        {
            this.session = s;
        }
        // Method to set pass a user object to the session
        public void SetUser(User user)
        {
            session.SetObject(SessionKey, user);
        }
        // Method to pass a list of characters to the session
        public void SetCharacters(List<Character> characters)
        {
            session.SetObject(CharactersKey, characters);
        }
        // Method GetCharacters() to pass a character object from the session to the controller
        public List<Character> GetCharacters() => session.GetObject<List<Character>>(CharactersKey);
        // Method GetUser() to pass a character object from the session to the controller
        public User GetUser() => session.GetObject<User>(SessionKey);
        // Call this to remove session data (for a logout or clear characters option)
        public void RemoveSessionData()
        {
            session.Remove(SessionKey);
            session.Remove(CharactersKey);
        }



    }
}

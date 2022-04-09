using dnd.Models.Characters;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace dnd.Models.Session
{
    public static class UserSession
    {
        // Override with Newtonsoft Json to convert objects passed into the session with these methods
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
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
        private const string UserSessionKey = "user";
        private const string CharacterListKey = "char";
        private const string ActiveCharacterKey = "active";
        private const string UserListKey = "users";
        private ISession session { get; set; }
        // Session declares a Session object and passes value to private session object
        public Session(ISession s)
        {
            this.session = s;
        }

        // Setter Methods to set pass a objects to the session
        public void SetUser(User user) { session.SetObject(UserSessionKey, user); }
        public void SetUserList(List<User> users) { session.SetObject(UserListKey, users); }
        public void SetActiveCharacter(Character character) { session.SetObject(ActiveCharacterKey, character); }
        public void SetCharacterList(List<Character> characters) { session.SetObject(CharacterListKey, characters); }

        // Getter Methods to pass session objects to the controller
        public User GetUser() => session.GetObject<User>(UserSessionKey);
        public List<User> GetUserList() => session.GetObject<List<User>>(UserListKey);
        public Character GetActiveCharacter() => session.GetObject<Character>(ActiveCharacterKey);
        public List<Character> GetCharacterList() => session.GetObject<List<Character>>(CharacterListKey);

        // Call this to remove session data (for a logout or clear characters option)
        public void RemoveSessionData()
        {
            session.Remove(UserSessionKey);
            session.Remove(UserListKey);
            session.Remove(ActiveCharacterKey);
            session.Remove(CharacterListKey);
        }



    }
}

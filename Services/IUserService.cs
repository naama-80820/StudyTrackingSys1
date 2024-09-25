using System.Collections.Generic;
using StudyTrackingSys1.Models;

public interface IUserService
{
    IEnumerable<User> GetAllUsers();
    User GetUserById(int id);
    User AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
    User GetUserByEmail(string email);
}

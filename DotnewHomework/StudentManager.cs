namespace DotnewHomework;

public class StudentManager
{
    List<User> users = new List<User>();

    public void addUser(User user)
    {
        users.Add(user);
        Console.WriteLine("Added user");
    }

    public List<User> getListUsers()
    {
        return users;
    }

    public void removeUser(User user)
    {
        users.Remove(user);
        Console.WriteLine("Removed user");
    }

    public String getbyId(String id)
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].ID.Equals(id))
            {
                return users[i].ID;
            }
        }

        return null;
    }
}
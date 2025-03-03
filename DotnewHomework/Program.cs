// See https://aka.ms/new-console-template for more information

using DotnewHomework;

StudentManager manager = new StudentManager();
User user1 = new User();
user1.FirstName="John";
user1.ID = "51235874";
user1.LastName = "Doe";
User user2 = new User();
user2.FirstName = "Jane";
user2.ID = "51235875";
user2.LastName = "Doe";
manager.addUser(user1);
manager.addUser(user2);
manager.getbyId("51235874");

manager.removeUser(user1);



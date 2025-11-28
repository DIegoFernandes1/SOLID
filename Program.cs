// See https://aka.ms/new-console-template for more information
using SOLID._02_OCP.Good;
using SOLID._03_LSP.Bad;
using SOLID._05_DIP.Good;

Console.WriteLine("Hello, World!");

var discount = new ElectronicDiscount();
discount.Calculate(500);

Discount discount2;
discount2 = new ClothingDiscount();
discount2.Calculate(150);

BankAccount account;
account = new SavingsAccount();
account.Withdraw(100);

//TANTO FAKEEMAIL QUANTO EMAIL PODEM SER USADO NA USERSERVICE POIS AMBOS IMPLEMENTAM A MESMA INTERFACE IEMAILSERVICE
var emailService = new FakeEmailService();
var userService = new UserService(emailService);

var emailService1 = new EmailService();
var userService1 = new UserService(emailService1);

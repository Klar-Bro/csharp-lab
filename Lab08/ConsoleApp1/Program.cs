using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        var letter = new Letter { Content = "Secret content of the letter." };
        var email = new Email { Content = "Important email message." };
        var sms = new SMS { Content = "Quick SMS notification." };

        var letterMessenger = new Messenger<Letter>();
        var emailMessenger = new Messenger<Email>();
        var smsMessenger = new Messenger<SMS>();

        letterMessenger.Send(letter); // Sending Letter: Secret content of the letter.
        emailMessenger.Send(email);   // Sending Email: Important email message.
        smsMessenger.Send(sms);       // Sending SMS: Quick SMS notification.
    }
}
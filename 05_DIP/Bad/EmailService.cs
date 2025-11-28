namespace SOLID._05_DIP.Bad
{
    /* É RUIM POIS QUALQUER MUDANÇA NA CLASSE EMAILSERVICE IMPACTA A CLASSE USERSERVICE
     * VIOLANDO O PRINCÍPIO DE INVERSÃO DE DEPENDÊNCIA
     */

    public class EmailService
    {
        public void send()
        {

        }
    }

    public class UserService(EmailService service)
    {

    }
}

namespace Commander.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }

        //We are mapping Command class. Removing attributes which we dont want to send to client
        //In this case, just for testing purposes, we deleted platform
        //In real life scenario, it could be something like a, instead of showing a person's year of birth, we could just show how old that person is
        /* public string Platform { get; set; } */
    }
}
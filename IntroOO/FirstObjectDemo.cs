namespace IntroOO
{
    internal class FirstObjectDemo
    {
        public static void Run()
        {
            /*
             JavaScript:
                let terje1 = {
                    firstName: 'Terje',
                    birthYear: 1975,
                }; 

                let terje2 = {};
                terje2.firstName = 'Terje';
                terje.birthYear = 1975;
             */

            var terje1 = new Person();
            terje1.FirstName = "Terje";
            terje1.BirthYear = 1975;

            var terje2 = new Person
            {
                FirstName = "Terje",
                BirthYear = 1975,
            };

            /*
             JavaScript:
                let model = {
                    person: {
                        firstName: 'Terje',
                        birthYear: 1975,
                    }
                }; 
             */

            var model1 = new ModelV1
            {
                Person = new Person
                {
                    FirstName = "Terje",
                    BirthYear = 1975,
                }
            };

            /*
             JavaScript:
                let model = {
                    people: [
                        {
                            firstName: 'Terje',
                            birthYear: 1975,
                        },
                        {
                            firstName: 'Per',
                            birthYear: 1980,
                        },
                    ]
                }; 
             */

            var model2 = new ModelV2
            {
                People = new Person[]
                {
                    new Person
                    {
                        FirstName = "Terje",
                        BirthYear = 1975,
                    },
                    new Person
                    {
                        FirstName = "Per",
                        BirthYear = 1980,
                    }
                }
            };

        }
    }
}

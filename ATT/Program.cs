// See https://aka.ms/new-console-template for more information

using ATT;

int id;


id = -1;
while (id != 0)
{



    Console.WriteLine("Ola, segue a tabela:\n\n");
    Console.WriteLine(" ID \t\t\t Nome\n");
    Console.WriteLine(" 1 \t\t\t Urutau");
    Console.WriteLine(" 2 \t\t\t Bicode Sapato");
    Console.WriteLine(" 3 \t\t\t Jubarte");
    Console.WriteLine(" 4 \t\t\t Piranha Abissal");
    Console.WriteLine(" 5 \t\t\t Toupeira");
    Console.WriteLine(" 6 \t\t\t Marmota\n");
    Console.WriteLine("Digite o ID Referente, para sair do programa digite 0\n");

    id = int.Parse(Console.ReadLine());



    switch (id)
    {

        case 1:


            //1° ANIMAL
            Console.Clear();
            animal animal1 = new animal();

            animal1.IdAnimal = 1;
            animal1.Nome = "Urutau";
            animal1.Genero = "Nyctibius";
            animal1.Reino = "Animalia";
            animal1.Classe = "Aves";
            animal1.Habitat = "Floresta";

            Console.WriteLine(animal1.IdAnimal);
            Console.WriteLine(animal1.Nome);
            Console.WriteLine(animal1.Genero);
            Console.WriteLine(animal1.Reino);
            Console.WriteLine(animal1.Classe);
            Console.WriteLine(animal1.Habitat + "\n");
            Console.WriteLine("Precione ENTER para voltar ao menu");
            Console.ReadLine();

            Console.Clear();
        break;

        case 2:

            //2° ANIMAL
            Console.Clear();
            animal animal2 = new animal();

            animal2.IdAnimal = 2;
            animal2.Nome = "Bicode Sapato";
            animal2.Genero = "Balaeniceps";
            animal2.Reino = "Animalia";
            animal2.Classe = "Aves";
            animal2.Habitat = "Floresta";

            Console.WriteLine(animal2.IdAnimal);
            Console.WriteLine(animal2.Nome);
            Console.WriteLine(animal2.Genero);
            Console.WriteLine(animal2.Reino);
            Console.WriteLine(animal2.Classe);
            Console.WriteLine(animal2.Habitat + "\n");
            Console.WriteLine("Precione ENTER para voltar ao menu");
            Console.ReadLine();

            Console.Clear();

        break;

        case 3:

            //3° ANIMAL
            Console.Clear();
            animal animal3 = new animal();

            animal3.IdAnimal = 3;
            animal3.Nome = "Jubarte";
            animal3.Genero = "Megaptera";
            animal3.Reino = "Animalia";
            animal3.Classe = "Mamifero";
            animal3.Habitat = "Mar";

            Console.WriteLine(animal3.IdAnimal);
            Console.WriteLine(animal3.Nome);
            Console.WriteLine(animal3.Genero);
            Console.WriteLine(animal3.Reino);
            Console.WriteLine(animal3.Classe);
            Console.WriteLine(animal3.Habitat + "\n");
            Console.WriteLine("Precione ENTER para voltar ao menu");
            Console.ReadLine();

            Console.Clear();

        break;

        case 4:

            //4° ANIMAL
            Console.Clear();
            animal animal4 = new animal();

            animal4.IdAnimal = 4;
            animal4.Nome = "Piranha Abissal";
            animal4.Genero = "Actinopterygii";
            animal4.Reino = "Animalia";
            animal4.Classe = "Carnivoro";
            animal4.Habitat = "Mar";

            Console.WriteLine(animal4.IdAnimal);
            Console.WriteLine(animal4.Nome);
            Console.WriteLine(animal4.Genero);
            Console.WriteLine(animal4.Reino);
            Console.WriteLine(animal4.Classe);
            Console.WriteLine(animal4.Habitat + "\n");
            Console.WriteLine("Precione ENTER para voltar ao menu");
            Console.ReadLine();

            Console.Clear();

        break;

        case 5:

            //5° ANIMAL
            Console.Clear();
            animal animal5 = new animal();

            animal5.IdAnimal = 5;
            animal5.Nome = "Toupeira";
            animal5.Genero = "Soricota";
            animal5.Reino = "Animalia";
            animal5.Classe = "Mammalia";
            animal5.Habitat = "Terra";

            Console.WriteLine(animal5.IdAnimal);
            Console.WriteLine(animal5.Nome);
            Console.WriteLine(animal5.Genero);
            Console.WriteLine(animal5.Reino);
            Console.WriteLine(animal5.Classe);
            Console.WriteLine(animal5.Habitat + "\n");
            Console.WriteLine("Precione ENTER para voltar ao menu");
            Console.ReadLine();

            Console.Clear();

        break;

        case 6:

            //6° ANIMAL
            Console.Clear();
            animal animal6 = new animal();

            animal6.IdAnimal = 6;
            animal6.Nome = "Marmota";
            animal6.Genero = "Esquilo Terrestre";
            animal6.Reino = "Animalia";
            animal6.Classe = "Mammalia";
            animal6.Habitat = "Terra";

            Console.WriteLine(animal6.IdAnimal);
            Console.WriteLine(animal6.Nome);
            Console.WriteLine(animal6.Genero);
            Console.WriteLine(animal6.Reino);
            Console.WriteLine(animal6.Classe);
            Console.WriteLine(animal6.Habitat + "\n");
            Console.WriteLine("Precione ENTER para voltar ao menu");
            Console.ReadLine();

            Console.Clear();

            break;
    }
}
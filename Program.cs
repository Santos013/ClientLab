using HelloWord.Classes;

// métodos genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();
List<PessoaFisica> listaPf = new List<PessoaFisica>(); //lista/array
List<PessoaJuridica> listaPj = new List<PessoaJuridica>(); //lista/array

//Cabeçalho
Console.WriteLine(@$"
===========================================
|    Bem vindo ao Sistema de cadastro de  |
|       Pessoas Física e Jurídica         |
===========================================
");


//loading
Utils.Loading("Iniciando o Sistema ", 500, 5, ConsoleColor.DarkBlue, ConsoleColor.White);

Console.WriteLine();//pular uma linha


string? opcao; //obs* está fora por causa do escopo


do
{   //laço do menu
    //MENU PRINCIPAL
    Console.WriteLine(@$"
===========================================
|    Escolha uma das opções abaixo:       |
|-----------------------------------------|
|       1 - Pessoa Física                 |
|       2 - Pessoa Jurídica               |
|                                         |
|       0 - Sair                          |
===========================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            //Pessoa Física
            Console.Clear();
            // *************** PESSOA FISICA ***************


            string? opcaoPf; //obs* fora do laço por causa do escopo

            do
            {   //laço submenu
                //Submenu Passoa Física
                Console.WriteLine(@$"
===========================================
|    Escolha uma das opções abaixo:       |
|-----------------------------------------|
|       1 - Cadastrar Pessoa Física       |
|       2 - Listar Pessoa Física          |
|                                         |
|       0 - Voltar ao Menu Anterior       |
===========================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1": //cadastrar pessoa física
                        Console.Clear();

                        // CADASTRO
                        // Endereço PF
                        Endereco endPf = new Endereco();

                        Console.WriteLine("Digite o Endereço: ");
                        endPf.Logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o Número: ");
                        endPf.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("O Endereço é Comercial? S/N");
                        string? endComercial = Console.ReadLine();
                        if (endComercial == "S")
                        {
                            endPf.Comercial = true;
                        }
                        else
                        {
                            endPf.Comercial = false;
                        }

                        //Cadastrando Pessoa Física
                        PessoaFisica novaPf = new PessoaFisica();

                        Console.WriteLine("Digite o Nome: ");
                        novaPf.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o CPF: ");
                        novaPf.Cpf = Console.ReadLine();

                        Console.WriteLine("Digite da de nascimento (ex: dd/mm/aaaa): ");
                        novaPf.DataNascimento = Console.ReadLine();

                        Console.WriteLine("Informe seu Rendimento: ");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        novaPf.Endereco = endPf;

                        //cadastrar na lista

                        using (StreamWriter arquivoPf = new StreamWriter("./PessoaFisisca.txt", false))
                        {
                            arquivoPf.WriteLine($"{novaPf.Nome},{novaPf.Cpf},{novaPf.DataNascimento},{novaPf.Rendimento},{novaPf.Endereco.Logradouro},{novaPf.Endereco.Numero},{novaPf.Endereco.Comercial}");
                        }

                        Console.WriteLine($"Cadastro com Sucesso");
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;

                    case "2": //listar pessoa física
                        Console.Clear();

                        Console.WriteLine($"**** Listagem Pessoa Física ****");

                        using (StreamReader arquivoPf = new StreamReader("./PessoaFisca.txt"))
                        {
                            string? linhaPessoa;

                            while ((linhaPessoa = arquivoPf.ReadLine()) != null)
                            {
                                string[] dadosPessoa = linhaPessoa.Split(",");
                                Console.WriteLine(@$"
Nome: {dadosPessoa[0]}
Cpf: {dadosPessoa[1]}
Data Nascimento: {dadosPessoa[2]}
Maior de Idade: {metodosPf.ValidarDataNascimento(dadosPessoa[2])}
Rendimento: R$ {dadosPessoa[3]}
Rendimento Liquido: R$ {metodosPf.PagarImposto(float.Parse(dadosPessoa[3]))}
Endereço: {dadosPessoa[4]}
Número: {dadosPessoa[5]}
");

                                Console.WriteLine("Endereço Comercial: " + (Boolean.Parse(dadosPessoa[6]) ? "Sim" : "Não"));

                            }
                        }

                        Console.WriteLine($"**** Fim da Listagem ****");
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;

                    case "0": // voltar menu anterior
                        Console.Clear();

                        Console.WriteLine($"Voltar ao menu anterior");
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;

                    default:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção Inválida");
                        Console.ResetColor();
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;
                }
                
            } while (opcaoPf != "0");

            Utils.ParadaNoConsole("Tecle <ENTER> para continuar!");
            Console.Clear();
            break;


        case "2":

            //Pessoa Jurídica
            // *************** PESSOA JURÍDICA ***************


            string? opcaoPj; //obs* fora do laço por causa do escopo

            do
            {   //laço submenu
                //Submenu Passoa Jurídica
                Console.WriteLine(@$"
===========================================
|    Escolha uma das opções abaixo:       |
|-----------------------------------------|
|       1 - Cadastrar Pessoa Jurídica     |
|       2 - Listar Pessoa Jurídica        |
|                                         |
|       0 - Voltar ao Menu Anterior       |
===========================================
");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1"://cadastar pessoa jurídica
                        Console.Clear();

                        //CADASTRO
                        //Endereço PJ
                        Endereco endPj = new Endereco();

                        Console.WriteLine("Digite o Endereço");
                        endPj.Logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o Número");
                        endPj.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("O endereço é comercial? S/N");
                        string? endComercial = Console.ReadLine();

                        if (endComercial == "S")
                        {
                            endPj.Comercial = true;
                        }
                        else
                        {
                            endPj.Comercial = false;
                        }


                        //Cadastrando Pessoa Jurídica
                        PessoaJuridica novaPj = new PessoaJuridica();

                        Console.WriteLine($"Digite a Razão Social: ");
                        novaPj.RazaoSocial = Console.ReadLine();

                        Console.WriteLine($"Digite o nome: ");
                        novaPj.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o CNPJ: ");
                        novaPj.Cnpj = Console.ReadLine();

                        Console.WriteLine($"Informe o Rendimento Bruto: ");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        novaPj.Endereco = endPj;

                        //cadastrar na lista

                        using (StreamWriter arquivoPj = new StreamWriter("./PessoaJuridica.txt", true))
                        {
                            arquivoPj.WriteLine($"{novaPj.RazaoSocial},{novaPj.Nome},{novaPj.Cnpj},{novaPj.Rendimento},{novaPj.Endereco.Logradouro},{novaPj.Endereco.Numero},{novaPj.Endereco.Comercial}");
                        }

                        Console.WriteLine($"Cadastro com Sucesso");

                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;


                    case "2": //listar pessoa jurídica
                        Console.Clear();

                        Console.WriteLine($"**** Listagem Pessoa Jurídica ****");

                        using (StreamReader arquivoPj = new StreamReader("./PessoaJuridica.txt"))
                        {
                            string? linhaPessoa;

                            while ((linhaPessoa = arquivoPj.ReadLine()) != null)
                            {
                                string[] dadosPessoa = linhaPessoa.Split(",");
                                Console.WriteLine(@$"
RazãoSocial: {dadosPessoa[0]}
Nome: {dadosPessoa[1]}
Cnpj: {dadosPessoa[2]}
Rendimento: R${dadosPessoa[3]}
Rendimento Líquido: R${metodosPj.PagarImposto(float.Parse(dadosPessoa[3]))}
Endereço: {dadosPessoa[4]}
Número: {dadosPessoa[5]}
");

                                Console.WriteLine("Endereço Comercial: " + (Boolean.Parse(dadosPessoa[6]) ? "Sim" : "Não"));
                            }
                        }


                        Console.WriteLine($"**** Fim da Listagem ****");
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;

                    case "0": // voltar menu anterior
                        Console.Clear();

                        Console.WriteLine($"Voltar ao menu anterior");
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;

                    default:
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção Inválida");
                        Console.ResetColor();
                        Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
                        break;
                }
            } while (opcaoPj != "0");

            Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
            Console.Clear();
            break;


        case "0":
            //sair
            Console.Clear();
            Console.WriteLine($"Obrigado por utulizar o sistema ");
            Utils.Loading("Finalizando o Sistema ", 500, 3, ConsoleColor.DarkBlue, ConsoleColor.White);
            Console.WriteLine();
            break;

        default:
            //opção inválida
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; //cor da fonte
            Console.WriteLine($"opção inválida");
            Console.ResetColor();

            Utils.ParadaNoConsole("Tecle <ENTER> para continuar");
            break;
    }
} while (opcao != "0");//menu principal







// ----------------------------------------------------------------------------------
// ********** atividade ER3 - ValidarDataNascimento ***********
// PessoaFisica novaPf = new PessoaFisica();

// Console.WriteLine( $"Maior de Idade? {novaPf.ValidarDataNascimento("02/10/1993")}");





// -----------------------------------------------------------------------------------
//aprendisagem

// Gravação
// using (StreamWriter arquivo = new StreamWriter($"./PessoaFisica.txt", true))
// {
//     arquivo.WriteLine("Fernando de Souza");
//     arquivo.Close();
// }

// using (StreamWriter arquivo = new StreamWriter($"./PessoaJuridica.txt", true))
// {
//     arquivo.WriteLine("Sapataria Bom Jose");
//     arquivo.Close();
// }

// Leitura
// using (StreamReader arquivo = new StreamReader("./PessoaFisica.txt"))
// {
//     string? linha;

//     while ( (linha = arquivo.ReadLine()) != null)
//     {
//         Console.WriteLine($"Nome: {linha}");

//     }
// }
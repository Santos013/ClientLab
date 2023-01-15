using HelloWord.Classes;

// ********** PESSOA FISICA **********

PessoaFisica metodosPf = new PessoaFisica();

// CADASTRO
//Endereço PF
Endereco endPf = new Endereco();
endPf.Logradouro = "Rua Adelmo Aires";
endPf.Numero = 123;
endPf.Comercial = false;

//Cadastrando Pessoa Física
PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Felipe";
novaPf.Cpf = "5500225544";
novaPf.DataNascimento = "02/10/1993";
novaPf.Rendimento = 1501;
novaPf.Endereco = endPf;

//Exibindo Pessoa Física
Console.WriteLine($"**** Pessoa Física ****");

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Cpf: {novaPf.Cpf}
Data Nascimento: {novaPf.DataNascimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPf.DataNascimento)}
Rendimento: R${novaPf.Rendimento}
Rendimento Líquido: R${metodosPf.PagarImposto((float)novaPf.Rendimento)}
Endereço: {novaPf.Endereco.Logradouro}
Numero: {novaPf.Endereco.Numero}
Endereço Comercial: {novaPf.Endereco.Comercial}
");


// ********* PESSOA JURIDICA **********

PessoaJuridica metodosPj = new PessoaJuridica();

//CADASTRO
//Endereço PJ
Endereco endPj = new Endereco();
endPj.Logradouro = "Rua Getulio Vargas";
endPj.Numero = 333;
endPj.Comercial = true;

//Cadastrando Pessoa Jurídica
PessoaJuridica novaPj = new PessoaJuridica();

novaPj.Nome = "Atacado FS";
novaPj.Cnpj = "07.277.567/0001-59";
novaPj.RazaoSocial = "Grupo Atacado FS Ltda";
novaPj.Rendimento = 137000;
novaPj.Endereco = endPj;

//Exibindo Pessoa Jurídica
Console.WriteLine($"**** Pessoa Jurídica ****");

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
Cnpj: {novaPj.Cnpj}
Cnpj Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Rendimento: R${novaPj.Rendimento}
Rendimento Líquido: R${metodosPj.PagarImposto((float)novaPj.Rendimento)}
Endereço: {novaPj.Endereco.Logradouro}
Numero: {novaPj.Endereco.Numero}
Endereço Comercial: {novaPj.Endereco.Comercial}
");



// ********** atividade ER3 - ValidarDataNascimento ***********
// PessoaFisica novaPf = new PessoaFisica();

// Console.WriteLine( $"Maior de Idade? {novaPf.ValidarDataNascimento("02/10/1993")}");
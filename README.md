# CadClientes API

<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/matheushoske/CadClientesAPI">
    <img src="https://github.com/matheushoske/CadClientesAPI/blob/main/images/swagger.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">API de Clientes</h3>

  <p align="center">
    Foi desenvolvida a API de consulta e inserção de clientes em asp.net core,
     utilizando uma documentação Swagger para facilitar os testes de requisição.</br>
A API contém:</br>
 2 métodos GET ( consulta de clientes por id e consulta de ultimo
cliente cadastrado) e 1 método POST (inserção de um novo cliente no banco
de dados).<br />
 Para o consumo da API, pode-se utilizar o Aplicativo em windows forms <a href="https://github.com/matheushoske/CadClientes">CadClientes</a>, ou a documentação em Swagger <br />
 No desenvolvimento da API, foi utilizado o banco de dados MySQL.
Não foi utilizado nenhum framework de ORM como o Entity Framework, a comunicação foi realizada diretamente do C# com o Banco de dados.</br>
<a href="#dbinstallation">Como instalar o MySQL </a>
    <br />
    <a href="https://www.w3schools.com/tags/ref_httpmethods.asp"><strong>Saiba mais sobre os métodos HTTP(GET & POST) »</strong></a>
    <br />
    <br />
    <a href="https://github.com/matheushoske/CadClientesAPI">Ver Demo</a>
    ·
    <a href="https://github.com/matheushoske/CadClientesAPI/issues">Report Bug</a>
    ·
    <a href="https://github.com/matheushoske/CadClientesAPI/issues">Requisitar Melhoria</a>
  </p>
</div>



<!-- TABLE OF CONTENTS 
<details>
  <summary>Conteúdos</summary>
  <ol>
    <li>
      <a href="#about-the-project">Sobre o projeto</a>
      <ul>
        <li><a href="#built-with">Liguagens utilizadas</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>-->



<!-- ABOUT THE PROJECT 
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

Here's a blank template to get started: To avoid retyping too much info. Do a search and replace with your text editor for the following: `github_username`, `repo_name`, `twitter_handle`, `linkedin_username`, `email`, `email_client`, `project_title`, `project_description`
-->
<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [C#](https://docs.microsoft.com/dotnet/csharp/)
* [MySQL](https://dev.mysql.com/doc/)

<p align="right">(<a href="#top">back to top</a>)</p>


## Getting Started
<!-- GETTING STARTED 

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.
-->
### Prerequisites

* .NET Framework 4.7.2 instalado
* Mysql instalado

<div id="dbinstallation"></div>

### MySQL Installation

Para o funcionamento correto da API, será necessário realizar a instalação e configuração do banco de dados MySQL

1. Para a instalação do serviço do MySQL será necessário primeiramente instalar e executar MySQL64bits.exe: [https://github.com/matheushoske/CadClientesAPIblob/master/MySQL64bits.exe](https://github.com/matheushoske/CadClientesAPI/MySQL64bits.exe)
2. Instalar e executar o conector do MySQL para .NET mysql-connector-net.msi: [https://github.com/matheushoske/CadClientesAPI/blob/master/mysql-connector-net.msi]
3. Execute as queries para criação do Banco sql-create.sql: https://github.com/matheushoske/CadClientesAPI/blob/master/sql-create.sql </br>
   Será realizada a criação do usuário 'rede' com senha 'rede' e o banco de dados bdclientes

<div id="dbinstallation"></div>

### API Installation

1. Clone o repository
   ```sh
   git clone https://github.com/matheushoske/CadClientesAPI.git
   ```
2. Abra o CadClientesAPI.sln e execute o projeto

Observações:
A API já virá totalmente configurada com swagger, IIS Express e comunicações com o Banco de dados criado, porém caso queira realizar alguma outra configuração, acesse os arquivos:

* launchsettings.json - Para a configurações de portas de execução, swagger e IIS.
* appsettings.json - Para a configuração da comunicação com o Banco de dados.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Como utilizar a API
É possível utilizar a api, tanto pelo Swagger, quanto pelo app CadClientes

1- Swagger </br>
  1.1 - Execute a API e acesse o caminho local. Padrão: https://localhost:44382/swagger/</br>
  1.2 - Na interface da API com swagger, você conseguirá realizar os testes de execução dos métodos, clique em [try out] no método que deseja executar</br>
  (inicie pelo POST,para cadastrar o primeiro cliente.), insira as informações do cliente no json exibido, e clique em execute.</br>
  <img src="https://github.com/matheushoske/CadClientesAPI/blob/main/images/swagger_post1.png" alt="Logo"></br></br>
  
2- Pelo APP CadClientes em Windows Forms</br>
  2.1 - Clone e executeo o projeto <a href="https://github.com/matheushoske/CadClientes">CadClientes</a></br>
  2.2 -Ao abrir, caso não exiba nenhuma mensagem de falha de comunicação com a API, o cadastro de clientes poderá ser realizado normalmente.</br>
      Caso exiba alguma mensagem de erro, verifique se sua API está executando corretamente, acesse as configurações
      e configure a URI da API corretamente</br>
   
_Para mais exemplos, acesse a documentação do CadClientes [Documentation](https://github.com/matheushoske/CadClientes)_

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ROADMAP 
## Roadmap

- [] Feature 1
- [] Feature 2
- [] Feature 3
    - [] Nested Feature-->

See the [open issues](https://github.com/matheushoske/CadClientes/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTRIBUTING 
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>-->



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Matheus Hoske - matheushoske@gmail.com

Project Link: [https://github.com/matheushoske/CadClientesAPI](https://github.com/matheushoske/CadClientesAPI)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS 
## Acknowledgments

* []()
* []()
* []()

<p align="right">(<a href="#top">back to top</a>)</p>-->



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/matheushoske/CadClientesAPI.svg?style=for-the-badge
[contributors-url]: https://github.com/matheushoske/CadClientesAPI/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/matheushoske/CadClientesAPI.svg?style=for-the-badge
[forks-url]: https://github.com/matheushoske/CadClientesAPI/network/members
[stars-shield]: https://img.shields.io/github/stars/matheushoske/CadClientesAPI.svg?style=for-the-badge
[stars-url]: https://github.com/matheushoske/CadClientesAPI/stargazers
[issues-shield]: https://img.shields.io/github/issues/matheushoske/CadClientesAPI.svg?style=for-the-badge
[issues-url]: https://github.com/matheushoske/CadClientesAPI/issues
[license-shield]: https://img.shields.io/github/license/matheushoske/CadClientesAPI.svg?style=for-the-badge
[license-url]: https://github.com/matheushoske/CadClientesAPI/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/matheus-hoske/
[product-screenshot]: images/swagger.png

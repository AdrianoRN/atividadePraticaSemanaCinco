using Microsoft.AspNetCore.Mvc;

namespace atividadePraticaSemanaCinco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            List<Jogador> ListaJogador = new List<Jogador>();

            ListaJogador.Add(new Jogador("João Paulo", 29));

            Jogador novaJogador = new Jogador();
            novaJogador.setNome("Chewbacca");
            novaJogador.setIdade(190);
            ListaJogador.Add(novaJogador);

            foreach (var Jogador in ListaJogador)
            {
                Console.WriteLine("Jogador: {0}, {1} anos", Jogador.getNome(), Jogador.getIdade());
            }

            return novaJogador.getNome();
        }
         [HttpPost]
        public string Post(string nome, int idade)
        {
            Jogador novaJogador = new Jogador(nome, idade);
            
            return novaJogador.getNome() + " - " + novaJogador.getIdade();
        }
    }
    
}

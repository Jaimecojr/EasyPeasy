using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Peliculas.Shared.Entity;


namespace Peliculas.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        private readonly HttpClient httpClient;

        public ServiceMovie(HttpClient httpClient){
            this.httpClient = httpClient;
        }
        private JsonSerializerOptions OpcionesPorDefectoJSON => new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

        /* Metodo Crear */
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T send){
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);   
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode,responseHttp);
        }    

        /* Los siguiente dos metodos nos permitiran obtener el id de la pelicula que acabo de crear */
        private async Task<T> DeserializarRespuesta<T> (HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions){
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        } 
        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T send){
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent); 
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        /* Metodo Consultar */
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        /*Metodo Para Modificar*/
        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, sendContent);   
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);    
        }

        /* Metodo ELiminar */
        public async Task<HttpResponseWrapper<object>> Delete (string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }


        public List<Movie> PeliculasGuardadas1 = new List<Movie>(){
            new Movie(){Id =1,Name="Las Vegas", Sinopsis="Ed Deline is a strict ex-CIA officer who went from being Head of Security to becoming President of Operations of the Montecito, whose job is to run the day-to-day operations of the casino. Following his departure, former Marine Danny McCoy, Ed's former protégé, becomes the Montecito's new President of Operations.", Poster="/Images/Movies/pelicula1.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =2,Name="Tengo ganas de ti", Sinopsis="Secuela de Tres metros sobre el cielo. La sexy Gin (Clara Lago) es el nuevo amor de Hache (Mario Casas), pero éste no puede olvidar a su antigua novia, Babi (María Valverde). Hache ha vuelto a casa tras pasar una temporada en Londres, alejado del recuerdo imborrable de aquel primer amor. Para poder reconstruir su vida y olvidar el pasado, Gin parece perfecta, pues es una chica de espíritu descarado, efervescente y vital que le hace creer que es posible revivir aquella magia. Pero tarde o temprano tendrá que encontrarse de nuevo con Babi.", Poster="/Images/Movies/pelicula2.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =3,Name="Una Navidad en verano", Sinopsis="Cuenta la historia de Daniela (Maricarmen Marín), una mujer luchadora que cuida a cuatro niños y a pocos días de la Navidad ocurre un hecho que cambia sus vidas para siempre, demostrando que el amor y la unión vence todos los retos.", Poster="/Images/Movies/pelicula3.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =4,Name="Venom: Carnage Liberado", Sinopsis="Venom 2 está en marcha y poco a poco vamos conociendo más detalles de esta nueva adaptación del Spiderverse de Sony Pictures junto a Marvel; tanto es así, que recientemente ha trascendido la aparición de Shriek en esta nueva película, una mítica villana de los cómics de Spider-Man que unirá fuerzas junto a su amado Cletus Kasady/Carnage para poner contra las cuerdas a Eddie Brock/Venom.", Poster="/Images/Movies/pelicula4.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =5,Name="Free Guy: Tomando el control", Sinopsis="Un hombre descubre que en realidad es un personaje dentro de un videojuego. Guy (Ryan Reynolds) trabaja como cajero de un banco, es un tipo alegre y solitario al que nada la amarga el día. Incluso si le utilizan como rehén durante un atraco a su banco, él sigue sonriendo como si nada. Pero un día se da cuenta de que Free City no es exactamente la ciudad que él creía. Guy va a descubrir que en realidad es un personaje no jugable dentro de un brutal videojuego. Ahora que sabe que es un personaje de videojuego, Guy, acompañado por Molotov Girl (Jodie Comer), decidirá enfrentarse a todos los villanos que asolan la ciudad.", Poster="/Images/Movies/pelicula5.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =6,Name="Los locos Addams 2", Sinopsis="Los Addams se enredan en aventuras más locas y se ven envueltos en divertidos enfrentamientos con todo tipo de personajes desprevenidos.", Poster="/Images/Movies/pelicula6.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =7,Name="BAC Nord Brigada Anticriminal", Sinopsis="A police brigade working in the dangerous northern neighborhoods of Marseille, where the level of crime is higher than anywhere else in France.", Poster="/Images/Movies/pelicula7.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =8,Name="Shang-Chi y la Leyenda de los Diez Anillos ", Sinopsis="Shang-Chi debe enfrentarse al pasado que pensó que había dejado atrás cuando se ve atraído por la red de la misteriosa organización de los Diez Anillos.", Poster="/Images/Movies/pelicula8.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =9,Name="Puños de la Venganza", Sinopsis="Un campeón de MMA es obligado a salir de su retiro para participar en una pelea y de paso desenmascarar una conspiración criminal.", Poster="/Images/Movies/pelicula9.jpg", Premier= new DateTime(2021,10,10)},
                new Movie(){Id =10,Name="Jungle Cruise", Sinopsis="Film ambientado a principios del siglo XX. Frank (Interpretado por Dwayne Johnson) es el carismático capitán de una peculiar embarcación que recorre la selva amazónica. Allí, a pesar de los peligros que el río Amazonas les tiene preparados, Frank llevará en su barco a la científica Lily Houghton (Interpretada por Emily Blunt) y a su hermano McGregor Houghton (Interpretado por Jack Whitehall).",Poster="/Images/Movies/pelicula10.jpg", Premier= new DateTime(2021,10,10)}
            };
            public List<Movie> PeliculasGuardadas{
                    get => PeliculasGuardadas1;
        set => PeliculasGuardadas1 = value;
            }
        public List<Movie> GetMovies(){
            return PeliculasGuardadas;
        }
        public void DeleteMovie(int ID)
        {
            foreach (var item in PeliculasGuardadas)
            {
                if(item.Id==ID){
                    PeliculasGuardadas.RemoveAt(ID-1);
                }
            }
        }
        public void AddMovie(Movie movie3){
            int numerodeMovies=PeliculasGuardadas1.Last().Id;
            movie3.Id=numerodeMovies+1;
            PeliculasGuardadas1.Add(movie3);
        }
    }
}
namespace AnagramTest
{
    using Xunit;
    using Shouldly;
    using Anagram;

    public class AnagramTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("R", "r")]
        [InlineData("aruba", null)]
        [InlineData("", "aruba")]
        [InlineData("Calor", "Carla")]
        [InlineData("Cardiografía", "radiografía")]
        [InlineData("Energéticamente", "genéricamente")]
        [InlineData("Fotoligografía", "litofotografía")]
        [InlineData("Caliente", "Alicante")]
        [InlineData("Topera", "trepaos")]
        public void ShouldLettersNotBeAnagrams(string a, string b)
        {
            var anagram = new Anagram();

            anagram.IsAnagram(a, b).ShouldBe(false);
        }

        [Theory]
        [InlineData("Alegan", "Ángela")]
        [InlineData("Riesgo", "Sergio")]
        [InlineData("Valora", "Álvaro")]
        [InlineData("Agonista", "Santiago")]
        [InlineData("Colinas", "Nicolás")]
        [InlineData("Quieren", "Enrique")]
        [InlineData("Prisa", "París")]
        [InlineData("Poder", "Pedro")]
        [InlineData("Ramón", "Norma")]
        [InlineData("Necrófila", "Florencia")]
        [InlineData("Armonía", "Mariano")]
        [InlineData("Mora", "Roma")]
        [InlineData("Salario", "Rosalía")]
        [InlineData("Saunas", "Susana")]
        [InlineData("Ovoide", "Oviedo")]
        [InlineData("Aretes", "Teresa")]
        [InlineData("Camelia", "Micaela")]
        [InlineData("Ventilan", "Valentín")]
        [InlineData("Enlodar", "Leandro")]
        [InlineData("Trama", "Marta")]
        [InlineData("Delira", "lidera")]
        [InlineData("Agranda", "granada")]
        [InlineData("Desamparador", "desparramado")]
        [InlineData("Licúa", "Lucía")]
        [InlineData("Conservadora", "conversadora")]
        [InlineData("Amor", "Roma")]
        [InlineData("Irónicamente", "renacimiento")]
        [InlineData("Nacionalista", "altisonancia")]
        [InlineData("Escandalizar", "zascandilear")]
        [InlineData("Frase", "fresa")]
        [InlineData("Enfriamiento", "refinamiento")]
        [InlineData("Integrarla", "Inglaterra")]
        [InlineData("Sórdidamente", "desmentidora")]
        [InlineData("Acuerdo", "Ecuador")]
        [InlineData("Materialismo", "memorialista")]
        [InlineData("Deudora", "Eduardo")]
        [InlineData("Presuposición", "superposición")]
        [InlineData("Saco", "cosa")]
        [InlineData("Enamoramientos", "armoniosamente")]
        [InlineData("Caldearnos", "encaradlos")]
        [InlineData("Rectificable", "certificable")]
        [InlineData("Aceleradnos", "acerándoles")]
        [InlineData("Reconquistados", "conquistadores")]
        [InlineData("Acertándoles", "altercándose")]
        [InlineData("Escabullimiento", "bulliciosamente")]
        [InlineData("Electromagnético", "magnetoeléctrico")]
        [InlineData("Posaré", "posera")]
        [InlineData("Imponderablemente", "imperdonablemente")]
        [InlineData("Armonización", "romanización")]
        [InlineData("Sopera", "sopear")]
        [InlineData("Pronosticación", "contraposición")]
        [InlineData("Áspero", "espora")]
        [InlineData("Nepal", "panel")]
        [InlineData("Aires", "Aries")]
        [InlineData("Raza", "Zara")]
        [InlineData("Presa", "rapés")]
        [InlineData("Pagar", "Praga")]
        [InlineData("Esta", "ates")]
        [InlineData("Cornisa", "Narciso")]
        [InlineData("Él", "le")]
        [InlineData("Amparo", "Páramo")]
        [InlineData("Resto", "retos")]
        [InlineData("Camino", "Mónica")]
        [InlineData("Reías", "ríase")]
        [InlineData("Matar", "Marta")]
        [InlineData("Terso", "teros")]
        public void ShouldLettersBeAnagrams(string a, string b)
        {
            var anagram = new Anagram();

            anagram.IsAnagram(a, b).ShouldBe(true);
        }

        [Theory]
        [InlineData("La contravino", "No la vi entrar")]
        [InlineData("Istmo de Panamá", "Tío San me da pan")]
        [InlineData("La revolución francesa", "un corso clave la fresa")]
        public void ShouldWordsNotBeAnagrams(string a, string b)
        {
            var anagram = new Anagram();

            anagram.IsAnagram(a, b).ShouldBe(false);
        } 

        [Theory]
        [InlineData("Anagrama", "amar, gana")]
        [InlineData("Anagramas", "a ganar más")]
        [InlineData("El huevo de chocolate", "hecho de vate locuelo")]
        [InlineData("Alborota", "rata, lobo")]
        public void ShouldWordsBeAnagrams(string a, string b)
        {
            var anagram = new Anagram();

            anagram.IsAnagram(a, b).ShouldBe(true);
        }
    }
}
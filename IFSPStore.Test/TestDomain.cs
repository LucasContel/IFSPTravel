using IFSPStore.Domain.Entities;
using System.Text.Json;
using System.Diagnostics;

namespace IFSPStore.Test
{
    [TestClass]
    public class TestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            Cidade cidade = new Cidade(1, "Birigui", "SP");

            Debug.WriteLine(JsonSerializer.Serialize(cidade));

            Assert.AreEqual(cidade.Nome, "Birigui");
            Assert.AreEqual(cidade.Estado, "SP");
        }

        [TestMethod]
        public void TestPassageiro()
        {
            Passageiro passageiro = new Passageiro(1, "Passageiro", "Telefone", "CPF", "Email");


            Debug.WriteLine(JsonSerializer.Serialize(passageiro));

            Assert.AreEqual(passageiro.Nome, "Passageiro");
            Assert.AreEqual(passageiro.Telefone, "Telefone");
            Assert.AreEqual(passageiro.Cpf, "CPF");
            Assert.AreEqual(passageiro.Email, "Email");

        }

        [TestMethod]
        public void TestOnibus()
        {
            
            List<Assento> assentos = new List<Assento>();

            Onibus onibus = new Onibus(1, "Placa", "Modelo", true, assentos);
            
            Assento assento = new Assento(1, 1, false, onibus);

            assentos.Add(assento);

            assento = new Assento(2, 2, true, onibus);

            assentos.Add(assento);

            Debug.WriteLine(JsonSerializer.Serialize(onibus));

            Assert.AreEqual(onibus.Placa, "Placa");
            Assert.AreEqual(onibus.Modelo, "Modelo");
            Assert.AreEqual(onibus.Wifi, true);
            Assert.AreEqual(onibus.Assentos, assentos);

        }


        [TestMethod]

        public void TestViagem()
        {
            List<Assento> assentos = new List<Assento>();

            Onibus onibus = new Onibus(1, "Placa", "Modelo", true, assentos);

            Assento assento = new Assento(1, 1, false, onibus);

            assentos.Add(assento);

            assento = new Assento(2, 2, true, onibus);

            assentos.Add(assento);

            Cidade origem = new Cidade(1, "Birigui", "SP");
            Cidade destino = new Cidade(2, "São Paulo", "SP");

            Viagem viagem = new Viagem(1, DateTime.Parse("2024-12-4 13:30:00"), DateTime.Parse("2024-12-4 16:40:00"), onibus, destino, origem);

            Debug.WriteLine(JsonSerializer.Serialize(viagem));

            Assert.AreEqual(viagem.DataSaida, DateTime.Parse("2024-12-4 13:30:00"));
            Assert.AreEqual(viagem.DataChegada, DateTime.Parse("2024-12-4 16:40:00"));
            Assert.AreEqual(viagem.Onibus, onibus);
            Assert.AreEqual(viagem.Destino, destino);
            Assert.AreEqual(viagem.Origem, origem);

        }

        [TestMethod]
        public void TestReserva()
        {

            List<Assento> assentos = new List<Assento>();

            Onibus onibus = new Onibus(1, "Placa", "Modelo", true, assentos);

            Assento assento = new Assento(1, 1, false, onibus);

            assentos.Add(assento);

            Cidade origem = new Cidade(1, "Birigui", "SP");

            Cidade destino = new Cidade(2, "São Paulo", "SP");

            Viagem viagem = new Viagem(1, DateTime.Parse("2024-12-4 13:30:00"), DateTime.Parse("2024-12-4 16:40:00"), onibus, destino, origem);

            Passageiro passageiro = new Passageiro(1, "Passageiro", "Telefone", "CPF", "Email");

            Reserva reserva = new Reserva(1, viagem, passageiro, assento);

            Debug.WriteLine(JsonSerializer.Serialize(reserva));

            Assert.AreEqual(reserva.Viagem, viagem);
            Assert.AreEqual(reserva.Passageiro, passageiro);
            Assert.AreEqual(reserva.Assento, assento);
        }

    }
}

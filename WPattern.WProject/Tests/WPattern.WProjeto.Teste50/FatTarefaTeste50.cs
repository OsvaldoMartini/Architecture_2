using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPattern.WProject.Data50;
using WPattern.WProject.Data50.Repository;
using WPattern.WProject.Data50.IRepository;

namespace WPattern.WProjeto.Teste50
{
    [TestClass]
    public class FatTarefaTeste50
    {

        private static IFatTarefaRepository repository { get; set; }

        //Inicialização dentro dos Testes	
        [ClassInitialize]
        public static void SetUp(TestContext testContext)
        {
            repository = new TFatTarefaRepository();
        }

        [TestMethod]
        public void FidAll50()
        {
            //gpvEntities50 entities50 = new gpvEntities50();

            //TFatTarefaRepository tarefaRepo = new TFatTarefaRepository();

            foreach (tFatTarefaEntity tarefa in repository.GetAll())
            {
                System.Diagnostics.Debug.WriteLine("tarefas 50:" + tarefa.UID_TAREFA + "-" + tarefa.NOME_TAREFA);
            }
        }


    }
}

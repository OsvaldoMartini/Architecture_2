using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPattern.WProject.Data6x;
using WPattern.WProject.Data6x.Repository;
using WPattern.WProject.Data6x.IRepository;

namespace WPattern.WProjeto.Teste6x
{
    [TestClass]
    public class FatTarefaTeste6x
    {

        private static IFatTarefaRepository repository {get; set;}
			
		//Inicialização dentro dos Testes	
		[ClassInitialize]	
		public static void SetUp(TestContext testContext)
		{
			repository = new TFatTarefaRepository();
		}

        [TestMethod]
        public void FidAll60()
        {
            //gpvEntities6x entities6x = new gpvEntities6x();

            //TFatTarefaRepository tarefaRepo = new TFatTarefaRepository();

            foreach (tFatTarefaEntity tarefa in repository.GetAll())
            {
                System.Diagnostics.Debug.WriteLine("tarefas 50:" + tarefa.UID_TAREFA + "-" + tarefa.NOME_TAREFA);
            }
        }
    }

    
}

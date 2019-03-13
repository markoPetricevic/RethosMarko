using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Concepts
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("Codebook")]
    public class CodebookInfo : IConceptInfo
    {
        [ConceptKey]
        public EntityInfo Entity { get; set; }
    }

    [Export(typeof(IConceptMacro))]
    public class CodebookMacro : IConceptMacro<CodebookInfo>
    {
        public IEnumerable<IConceptInfo> CreateNewConcepts(
            CodebookInfo conceptInfo, IDslModel existingConcepts)
        {
            var newConcepts = new List<IConceptInfo>();

            var poljeOznaka = new ShortStringPropertyInfo
            {
                Name = "Oznaka",
                DataStructure = conceptInfo.Entity
            };
            newConcepts.Add(poljeOznaka);
            newConcepts.Add(new AutoCodePropertyInfo
            {
                Property = poljeOznaka
            });

            var poljeNaziv = new ShortStringPropertyInfo
            {
                Name = "Naziv",
                DataStructure = conceptInfo.Entity
            };
            newConcepts.Add(poljeNaziv);
            newConcepts.Add(new RequiredPropertyInfo
            {
                Property = poljeNaziv
            });

            return newConcepts;
        }
    }
}

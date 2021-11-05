using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MiningSystem
{
    public class Article
    {
        private string Title;
        private string Text;
        private string Data_Set;
        private List<string> ClassCodes = new List<string>();

        public Article() { }

        public Article(string Title, string Text, List<string> ClassCodes, string Data_Set)
        {
            this.Title = Title;
            this.Text = Text;
            this.ClassCodes = ClassCodes;
            this.Data_Set = Data_Set;
        }

        public string getTitle()
        {
            return Title;
        }

        public void setTitle(string value)
        {
            Title = value;
        }

        public string getText()
        {
            return Text;
        }

        public void setText(string value)
        {
            Text = value;
        }

        public string getDataSet()
        {
            return Data_Set;
        }

        public void setDatSet(string value)
        {
            Data_Set = value;
        }

        public List<string> getClassCodes()
        {
            return ClassCodes;
        }

        public string GetXmlNodeContentByName(XmlDocument obj, string numeNod)
        {
            string info = "";

            XmlNode nodeTitle = obj.DocumentElement.SelectSingleNode(numeNod);
            info += nodeTitle.InnerText;

            return info.ToLower();
        }

        public List<string> GetClassCodesFromXml(XmlDocument obj)
        {
            List<string> nodsContainingBipTopics = new List<string>();

            XmlNode nodMetadataParentsCodes = obj.DocumentElement.SelectSingleNode("metadata");
            XmlNodeList childeNodesWithCodes = nodMetadataParentsCodes.ChildNodes;

            foreach (XmlNode CodesNode in childeNodesWithCodes)
            {
                foreach (XmlAttribute atributNoduCodes in CodesNode.Attributes)
                {
                    if (atributNoduCodes.Value.Equals("bip:topics:1.0"))
                    {
                        XmlNodeList noduriCopilCodes = CodesNode.ChildNodes;

                        foreach (XmlNode noduriCode in noduriCopilCodes)
                        {
                            foreach (XmlAttribute atributNoduriCode in noduriCode.Attributes)
                            {
                                string auxString = atributNoduriCode.Value;
                                nodsContainingBipTopics.Add(auxString.ToLower());
                            }
                        }
                    }
                }
            }

            return nodsContainingBipTopics;
        }

        public List<Article> CheckAndInitiateXMLFiles(string caleRelativaCatreFolderCuFisiere)
        {
            List<Article> listaFisiereXml = new List<Article>();
            string cale = @"./../../../InputData/" + caleRelativaCatreFolderCuFisiere;
            string folder = "";
            XmlDocument xmlDocument = new();
            string[] allDirectories = Directory.GetFiles(cale, "*", SearchOption.AllDirectories);

            for (var i = 0; i < allDirectories.Length; i++)
            {
                if (allDirectories[i].EndsWith("XML"))
                {
                    if (allDirectories[i].Contains("Training"))
                    {
                        folder = "training";
                    }
                    if (allDirectories[i].Contains("Testing"))
                    {
                        folder = "testing";
                    }

                    xmlDocument.Load(allDirectories[i]);
                    Article obj = new Article(GetXmlNodeContentByName(xmlDocument, "title"),
                                              GetXmlNodeContentByName(xmlDocument, "text"),
                                              GetClassCodesFromXml(xmlDocument),
                                              folder);

                    listaFisiereXml.Add(obj);
                    folder = "";
                }
            }

            
            return listaFisiereXml;
        }

    }
}

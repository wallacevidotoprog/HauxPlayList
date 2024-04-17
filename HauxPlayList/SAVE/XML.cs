using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HauxPlayList.SAVE
{
    #region xmlPlayList
    

    [XmlRoot(ElementName = "infos")]
    public class Infos
    {

        [XmlElement(ElementName = "nomePlayList")]
        public object NomePlayList { get; set; }

        [XmlElement(ElementName = "descricaoPlayList")]
        public object DescricaoPlayList { get; set; }

        [XmlElement(ElementName = "imagePlayList")]
        public object ImagePlayList { get; set; }
    }

    [XmlRoot(ElementName = "xPlayList")]
    public class XPlayList
    {

        [XmlElement(ElementName = "nomeMusica")]
        public object NomeMusica { get; set; }

        [XmlElement(ElementName = "caminhoMusica")]
        public object CaminhoMusica { get; set; }

        [XmlAttribute(AttributeName = "xmucisca")]
        public int Xmucisca { get; set; }
    }

    [XmlRoot(ElementName = "PlayList")]
    public class PlayList
    {

        [XmlElement(ElementName = "infos")]
        public Infos Infos { get; set; }

        [XmlElement(ElementName = "xPlayList")]
        public XPlayList XPlayList { get; set; }
    }

    #endregion

    #region configs

    [XmlRoot(ElementName = "Configs")]
    public class Configs
    {

        [XmlElement(ElementName = "pastaBase")]
        public string PastaBase { get; set; }
        [XmlElement(ElementName = "subPastaBase")]
        public string SubPastaBase { get; set; }
    }

    
    #endregion

}

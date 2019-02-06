using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

namespace BrokenSocialScene
{
    public partial class SongForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataList();
            }
        }

        private void BindDataList()
        {
            XmlTextReader reader = new XmlTextReader(Server.MapPath("~/App_Data/Songs.xml"));
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            reader.Close();

            if(ds.Tables.Count != 0)
            {
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                DataList1.DataSource = null;
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Server.MapPath("~/App_Data/Songs.xml"));

            XmlElement parentelement = xmldoc.CreateElement("PlayList");

            XmlElement song = xmldoc.CreateElement("song");
            song.InnerText = TextBox1.Text;

            XmlElement album = xmldoc.CreateElement("album");
            album.InnerText = TextBox2.Text;

            XmlElement track = xmldoc.CreateElement("track");
            track.InnerText = TextBox3.Text;

            parentelement.AppendChild(song);
            parentelement.AppendChild(album);
            parentelement.AppendChild(track);

            xmldoc.DocumentElement.AppendChild(parentelement);
            xmldoc.Save(Server.MapPath("~/App_Data/Songs.xml"));
            BindDataList();
        }
    }
}

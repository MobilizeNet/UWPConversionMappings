using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace UpgradeHelpers
{
	public static class SyndicationFeedLoadHelper
	{
		public static Windows.Web.Syndication.SyndicationFeed Load(System.Xml.XmlReader xmlreader)
		{
			Windows.Web.Syndication.SyndicationFeed feed = new Windows.Web.Syndication.SyndicationFeed();//).Load(xmlReader);

			/// NOTE we do this conversion because it is not possible to load an "Windows.Data.Xml.Dom.XmlDocument" instance with
			/// a System.Xml.XmlReader
			var tempdocument = (new System.Xml.XmlDocument());
			tempdocument.Load(xmlreader);
			StringWriter writer = new StringWriter();
			var xmlwriter = XmlWriter.Create(writer);
			tempdocument.WriteTo(xmlwriter);
			xmlwriter.Flush();
			writer.Flush();
			feed.Load(writer.ToString());
			return feed;
		}
	}
}

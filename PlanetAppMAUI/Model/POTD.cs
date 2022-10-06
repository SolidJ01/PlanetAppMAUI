using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetAppMAUI.Model
{
    public class POTD
    {
        private string date;
        public string Date { get { return date; } }

        private string explanation;
        public string Explanation { get { return explanation; } }

        private string hdurl;
        public string Hdurl { get { return hdurl; } }

        private string media_type;
        public string MediaType { get { return media_type; } }

        private string service_version;
        public string ServiceVersion { get { return service_version; } }

        private string title;
        public string Title { get { return title; } }

        private string url;
        public string Url { get { return url; } }

        public POTD(string date, string explanation, string hdurl, string media_type, string service_version, string title, string url)
        {
            this.date = date;
            this.explanation = explanation;
            this.hdurl = hdurl;
            this.media_type = media_type;
            this.service_version = service_version;
            this.title = title;
            this.url = url;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Lectures
/// </summary>

    public class Lectures
    {
        private string p_uri;

        public int Id { get; set; }
        public string LectureName { get; set; }
        public string LectureDescription { get; set; }
        public string PictureUri
        {
            get
            {
                return string.IsNullOrEmpty(p_uri) ? "" : p_uri;
            }
            set { p_uri = value; }
        }
        public string instructor { get; set; }
        public string instructor_name { get; set; }

    }

namespace Harmic.Areas.Admin.Models
{
    public class SummerNote
    {
        public SummerNote(string idEditor, bool loadLibrary = true)
        {
            IDEditor = idEditor;
            LoadLibary = loadLibrary;
        }
        public string IDEditor { get; set; }
        public bool LoadLibary { get; set; }
        public int Height { get; set; } = 500;
        public string toolBar { get; set; } = @"
            [
                ['style' , ['style']],
                ['font' , ['bold','underline','clear']],
                ['color' , ['color']],
                ['para' , ['ul','uo','paragraph']],
                ['table' , ['table']],
                ['insert' , ['link','elfindFiles','video','elfinder']],
                ['view' , ['fullscreen','codeview','help']],
            ]
        ";
    }
}

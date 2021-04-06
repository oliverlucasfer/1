namespace SmartSchool.WebAPI.Helpers
{
    public class PageParams
    {
        public const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int pageSize_ { 
            get { return pageSize; } 
            set { pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }

        public int? Matricula { get; set; } = null;
        public string Nome { get; set; } = string.Empty;
        public int? Ativo { get; set; } = null;
    }
}
using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
namespace GWFormBuilder.Models{
	 	//数据元缘逻辑关系表
		public class DRR_DATAMETALOGICAL
	{
   		     
      	/// <summary>
		/// 数据元内部标识码
        /// </summary>		
		private string _datametainnerid;
        [StringLength(100)]
        public string DATAMETAINNERID
        {
            get{ return _datametainnerid; }
            set{ _datametainnerid = value; }
        }        
		/// <summary>
		/// 数据集编码
        /// </summary>		
		private string _dataset_id;
        [StringLength(100)]
        public string DATASET_ID
        {
            get{ return _dataset_id; }
            set{ _dataset_id = value; }
        }        
		/// <summary>
		/// 项目编码
        /// </summary>		
		private string _project_id;
        [StringLength(100)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// 执行方法字符串
        /// </summary>		
		private string _fun_str;
        [StringLength(300)]
        public string FUN_STR
        {
            get{ return _fun_str; }
            set{ _fun_str = value; }
        }        
		   
	}
}


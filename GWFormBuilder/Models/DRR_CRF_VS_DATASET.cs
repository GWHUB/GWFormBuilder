using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
namespace GWFormBuilder.Models
{
	 	//CRF关联数据集表
		public class DRR_CRF_VS_DATASET
	{
   		     
      	/// <summary>
		/// 模板编号
        /// </summary>		
		private string _templet_id;
        [StringLength(50)]
        public string TEMPLET_ID
        {
            get{ return _templet_id; }
            set{ _templet_id = value; }
        }        
		/// <summary>
		/// 数据集编码
        /// </summary>		
		private string _dataset_code;
        [StringLength(50)]
        public string DATASET_CODE
        {
            get{ return _dataset_code; }
            set{ _dataset_code = value; }
        }        
		/// <summary>
		/// 时间戳
        /// </summary>		
		private DateTime _timestamp;
        public DateTime TIMESTAMP
        {
            get{ return _timestamp; }
            set{ _timestamp = value; }
        }        
		/// <summary>
		/// 删除标记
        /// </summary>		
		private Int16 _del_flag;
        public Int16 DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// 排序标记
        /// </summary>		
		private Int16 _show_order;
        public Int16 SHOW_ORDER
        {
            get{ return _show_order; }
            set{ _show_order = value; }
        }        
		   
	}
}


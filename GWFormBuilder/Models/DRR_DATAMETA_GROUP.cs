using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
namespace GWFormBuilder.ModelModels
{
    //数据元分组
		public class DRR_DATAMETA_GROUP
	{
   		     
      	/// <summary>
		/// 组别id
        /// </summary>		
		private Int16 _group_id;
        public Int16 GROUP_ID
        {
            get{ return _group_id; }
            set{ _group_id = value; }
        }        
		/// <summary>
		/// 组别名称
        /// </summary>		
		private string _group_name;
        [StringLength(200)]
        public string GROUP_NAME
        {
            get{ return _group_name; }
            set{ _group_name = value; }
        }        
		/// <summary>
		/// 创建人id
        /// </summary>		
		private string _create_manid;
        [StringLength(50)]
        public string CREATE_MANID
        {
            get{ return _create_manid; }
            set{ _create_manid = value; }
        }        
		/// <summary>
		/// 创建时间
        /// </summary>		
		private DateTime _create_date;
        public DateTime CREATE_DATE
        {
            get{ return _create_date; }
            set{ _create_date = value; }
        }        
		/// <summary>
		/// 项目id
        /// </summary>		
		private string _project_id;
        [StringLength(100)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// 组来源
        /// </summary>		
		private string _group_from;
        [StringLength(100)]
        public string GROUP_FROM
        {
            get{ return _group_from; }
            set{ _group_from = value; }
        }        
		/// <summary>
		/// 填报项
        /// </summary>		
		private string _group_prefixname;
        [StringLength(300)]
        public string GROUP_PREFIXNAME
        {
            get{ return _group_prefixname; }
            set{ _group_prefixname = value; }
        }        
		/// <summary>
		/// 删除标记 0未删除，1已删除
        /// </summary>		
		private string _del_flag;
        [StringLength(20)]
        public string DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _group_element;
        [StringLength(500)]
        public string GROUP_ELEMENT
        {
            get{ return _group_element; }
            set{ _group_element = value; }
        }        
		/// <summary>
		/// 拼音
        /// </summary>		
		private string _input_code;
        [StringLength(100)]
        public string INPUT_CODE
        {
            get{ return _input_code; }
            set{ _input_code = value; }
        }        
		/// <summary>
		/// 组内容
        /// </summary>		
		private string _group_info;
        [StringLength(300)]
        public string GROUP_INFO
        {
            get{ return _group_info; }
            set{ _group_info = value; }
        }        
		   
	}
}


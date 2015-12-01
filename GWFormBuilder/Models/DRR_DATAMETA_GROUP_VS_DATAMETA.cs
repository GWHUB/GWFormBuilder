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
		public class DRR_DATAMETA_GROUP_VS_DATAMETA
	{
   		     
      	/// <summary>
		/// 组别id?
        /// </summary>		
		private string _group_id;
        [StringLength(300)]
        public string GROUP_ID
        {
            get{ return _group_id; }
            set{ _group_id = value; }
        }        
		/// <summary>
		/// 数据元标示符
        /// </summary>		
		private string _datameta_identity;
        [StringLength(300)]
        public string DATAMETA_IDENTITY
        {
            get{ return _datameta_identity; }
            set{ _datameta_identity = value; }
        }        
		/// <summary>
		/// 数据元名称
        /// </summary>		
		private string _datameta_name;
        [StringLength(300)]
        public string DATAMETA_NAME
        {
            get{ return _datameta_name; }
            set{ _datameta_name = value; }
        }        
		/// <summary>
		/// 所属项目
        /// </summary>		
		private string _project_id;
        [StringLength(300)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
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
		/// 父级数据元标示符
        /// </summary>		
		private string _father_datametaidentity;
        [StringLength(100)]
        public string FATHER_DATAMETAIDENTITY
        {
            get{ return _father_datametaidentity; }
            set{ _father_datametaidentity = value; }
        }        
		/// <summary>
		/// 数据元动作处理的函数　１，隐藏，0 显示 ,2 插入 6加7 减
        /// </summary>		
		private string _datameta_action;
        [StringLength(300)]
        public string DATAMETA_ACTION
        {
            get{ return _datameta_action; }
            set{ _datameta_action = value; }
        }        
		/// <summary>
		/// 父级嵌套关系 c在父数据元后面，数字时等于该值时显示
        /// </summary>		
		private string _father_relation;
        [StringLength(100)]
        public string FATHER_RELATION
        {
            get{ return _father_relation; }
            set{ _father_relation = value; }
        }        
		/// <summary>
		/// 父级连接字符串
        /// </summary>		
		private string _father_connstr;
        [StringLength(300)]
        public string FATHER_CONNSTR
        {
            get{ return _father_connstr; }
            set{ _father_connstr = value; }
        }        
		/// <summary>
		/// 数据元内部标示符
        /// </summary>		
		private string _metadata_inner_identify;
        [StringLength(100)]
        public string METADATA_INNER_IDENTIFY
        {
            get{ return _metadata_inner_identify; }
            set{ _metadata_inner_identify = value; }
        }        
		/// <summary>
		/// 是否是主数据元 0是， 1 否
        /// </summary>		
		private string _is_father;
        [StringLength(20)]
        public string IS_FATHER
        {
            get{ return _is_father; }
            set{ _is_father = value; }
        }        
		/// <summary>
		/// 是否是计算数据元0，否，1是
        /// </summary>		
		private string _is_compute;
        [StringLength(20)]
        public string IS_COMPUTE
        {
            get{ return _is_compute; }
            set{ _is_compute = value; }
        }        
		/// <summary>
		/// 显示顺序
        /// </summary>		
		private Int16 _shor_order;
        public Int16 SHOR_ORDER
        {
            get{ return _shor_order; }
            set{ _shor_order = value; }
        }        
		   
	}
}


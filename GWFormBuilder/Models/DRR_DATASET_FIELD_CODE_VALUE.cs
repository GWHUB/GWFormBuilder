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
	 	//数据集下值域允许值
		public class DRR_DATASET_FIELD_CODE_VALUE
	{
   		     
      	/// <summary>
		/// 项目编码
        /// </summary>		
		private string _project_id;
        [StringLength(50)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// 病种编码
        /// </summary>		
		private string _disease_id;
        [StringLength(50)]
        public string DISEASE_ID
        {
            get{ return _disease_id; }
            set{ _disease_id = value; }
        }        
		/// <summary>
		/// 数据元内部标识码
        /// </summary>		
		private string _metadata_inner_identify;
        [StringLength(100)]
        public string METADATA_INNER_IDENTIFY
        {
            get{ return _metadata_inner_identify; }
            set{ _metadata_inner_identify = value; }
        }        
		/// <summary>
		/// 值域编码
        /// </summary>		
		private string _fieldcode_tablecode;
        [StringLength(100)]
        public string FIELDCODE_TABLECODE
        {
            get{ return _fieldcode_tablecode; }
            set{ _fieldcode_tablecode = value; }
        }        
		/// <summary>
		/// 允许值
        /// </summary>		
		private string _fieldcode_value;
        [StringLength(100)]
        public string FIELDCODE_VALUE
        {
            get{ return _fieldcode_value; }
            set{ _fieldcode_value = value; }
        }        
		/// <summary>
		/// 值含义
        /// </summary>		
		private string _fieldcode_value_cn_name;
        [StringLength(300)]
        public string FIELDCODE_VALUE_CN_NAME
        {
            get{ return _fieldcode_value_cn_name; }
            set{ _fieldcode_value_cn_name = value; }
        }        
		/// <summary>
		/// 值含义英文名
        /// </summary>		
		private string _fieldcode_value_eg_name;
        [StringLength(200)]
        public string FIELDCODE_VALUE_EG_NAME
        {
            get{ return _fieldcode_value_eg_name; }
            set{ _fieldcode_value_eg_name = value; }
        }        
		/// <summary>
		/// 值描述
        /// </summary>		
		private string _fieldcode_value_describe;
        [StringLength(300)]
        public string FIELDCODE_VALUE_DESCRIBE
        {
            get{ return _fieldcode_value_describe; }
            set{ _fieldcode_value_describe = value; }
        }        
		/// <summary>
		/// 计算值
        /// </summary>		
		private string _field_compute;
        [StringLength(50)]
        public string FIELD_COMPUTE
        {
            get{ return _field_compute; }
            set{ _field_compute = value; }
        }        
		/// <summary>
		/// 拼音码
        /// </summary>		
		private string _input_code;
        [StringLength(50)]
        public string INPUT_CODE
        {
            get{ return _input_code; }
            set{ _input_code = value; }
        }        
		/// <summary>
		/// 允许值来源
        /// </summary>		
		private string _field_from;
        [StringLength(100)]
        public string FIELD_FROM
        {
            get{ return _field_from; }
            set{ _field_from = value; }
        }        
		/// <summary>
		/// 状态
        /// </summary>		
		private string _status;
        [StringLength(50)]
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// 删除标记
        /// </summary>		
		private string _del_flag;
        [StringLength(20)]
        public string DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// 金标准对应编码
        /// </summary>		
		private string _field_nameid;
        [StringLength(50)]
        public string FIELD_NAMEID
        {
            get{ return _field_nameid; }
            set{ _field_nameid = value; }
        }        
		/// <summary>
		/// 排序
        /// </summary>		
		private string _fieldorder;
        [StringLength(50)]
        public string FIELDORDER
        {
            get{ return _fieldorder; }
            set{ _fieldorder = value; }
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
		/// 创建人
        /// </summary>		
		private string _create_man;
        [StringLength(100)]
        public string CREATE_MAN
        {
            get{ return _create_man; }
            set{ _create_man = value; }
        }        
		/// <summary>
		/// 版本号
        /// </summary>		
		private string _version;
        [StringLength(100)]
        public string VERSION
        {
            get{ return _version; }
            set{ _version = value; }
        }        
		/// <summary>
		/// 版本日期
        /// </summary>		
		private DateTime _version_date;
        public DateTime VERSION_DATE
        {
            get{ return _version_date; }
            set{ _version_date = value; }
        }        
		   
	}
}


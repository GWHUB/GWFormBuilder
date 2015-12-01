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
		public class DRR_DATAMETA_FIELD_CODE
	{
   		     
      	/// <summary>
		/// 值域代码表表号
        /// </summary>		
		private string _fieldcode_tablecode;
        [StringLength(100)]
        public string FIELDCODE_TABLECODE
        {
            get{ return _fieldcode_tablecode; }
            set{ _fieldcode_tablecode = value; }
        }        
		/// <summary>
		/// 分组标识
        /// </summary>		
		private string _group_identify;
        [StringLength(100)]
        public string GROUP_IDENTIFY
        {
            get{ return _group_identify; }
            set{ _group_identify = value; }
        }        
		/// <summary>
		/// 值英文名
        /// </summary>		
		private string _fieldcode_value_eg_name;
        [StringLength(100)]
        public string FIELDCODE_VALUE_EG_NAME
        {
            get{ return _fieldcode_value_eg_name; }
            set{ _fieldcode_value_eg_name = value; }
        }        
		/// <summary>
		/// 无歧义标识
        /// </summary>		
		private string _clear_dentify;
        [StringLength(100)]
        public string CLEAR_DENTIFY
        {
            get{ return _clear_dentify; }
            set{ _clear_dentify = value; }
        }        
		/// <summary>
		/// 对应同义词的值
        /// </summary>		
		private string _synonym_value;
        [StringLength(100)]
        public string SYNONYM_VALUE
        {
            get{ return _synonym_value; }
            set{ _synonym_value = value; }
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
		/// 五笔
        /// </summary>		
		private string _wubi_code;
        [StringLength(100)]
        public string WUBI_CODE
        {
            get{ return _wubi_code; }
            set{ _wubi_code = value; }
        }        
		/// <summary>
		/// 创建日期
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
		/// 状态 0可用 ，1审核，2合并，3删除
        /// </summary>		
		private string _status;
        [StringLength(20)]
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
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
		/// 项目编号
        /// </summary>		
		private string _project_id;
        [StringLength(50)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
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
		/// 来源
        /// </summary>		
		private string _field_from;
        [StringLength(100)]
        public string FIELD_FROM
        {
            get{ return _field_from; }
            set{ _field_from = value; }
        }        
		/// <summary>
		/// 概念域
        /// </summary>		
		private string _field_conceptualdomain;
        [StringLength(300)]
        public string FIELD_CONCEPTUALDOMAIN
        {
            get{ return _field_conceptualdomain; }
            set{ _field_conceptualdomain = value; }
        }        
		/// <summary>
		/// 值域类型（1位数字代码）
        /// </summary>		
		private string _fieldtype;
        [StringLength(20)]
        public string FIELDTYPE
        {
            get{ return _fieldtype; }
            set{ _fieldtype = value; }
        }        
		/// <summary>
		/// 值域名称
        /// </summary>		
		private string _fieldcode_name;
        [StringLength(100)]
        public string FIELDCODE_NAME
        {
            get{ return _fieldcode_name; }
            set{ _fieldcode_name = value; }
        }        
		/// <summary>
		/// 概念域id 
        /// </summary>		
		private string _field_conceptualdomain_id;
        [StringLength(50)]
        public string FIELD_CONCEPTUALDOMAIN_ID
        {
            get{ return _field_conceptualdomain_id; }
            set{ _field_conceptualdomain_id = value; }
        }        
		/// <summary>
		/// 上次更新时间
        /// </summary>		
		private DateTime _lastupdate_date;
        public DateTime LASTUPDATE_DATE
        {
            get{ return _lastupdate_date; }
            set{ _lastupdate_date = value; }
        }        
		/// <summary>
		/// 最近使用时间
        /// </summary>		
		private DateTime _lastuse_date;
        public DateTime LASTUSE_DATE
        {
            get{ return _lastuse_date; }
            set{ _lastuse_date = value; }
        }        
		/// <summary>
		/// 上次使用用户ID
        /// </summary>		
		private string _lastuse_userid;
        [StringLength(50)]
        public string LASTUSE_USERID
        {
            get{ return _lastuse_userid; }
            set{ _lastuse_userid = value; }
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


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
		public class DRR_DATAMETA_FEATURE_DICT
	{
   		     
      	/// <summary>
		/// 特性标示
        /// </summary>		
		private string _feature_identity;
        [StringLength(100)]
        public string FEATURE_IDENTITY
        {
            get{ return _feature_identity; }
            set{ _feature_identity = value; }
        }        
		/// <summary>
		/// 特性名称
        /// </summary>		
		private string _feature_name;
        [StringLength(500)]
        public string FEATURE_NAME
        {
            get{ return _feature_name; }
            set{ _feature_name = value; }
        }        
		/// <summary>
		/// 特性描述
        /// </summary>		
		private string _feature_describe;
        [StringLength(300)]
        public string FEATURE_DESCRIBE
        {
            get{ return _feature_describe; }
            set{ _feature_describe = value; }
        }        
		/// <summary>
		/// 创建人
        /// </summary>		
		private string _create_man;
        [StringLength(200)]
        public string CREATE_MAN
        {
            get{ return _create_man; }
            set{ _create_man = value; }
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
		/// 删除标记
        /// </summary>		
		private Int16 _del_flag;
        public Int16 DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// 拼音码
        /// </summary>		
		private string _input_code;
        [StringLength(100)]
        public string INPUT_CODE
        {
            get{ return _input_code; }
            set{ _input_code = value; }
        }        
		/// <summary>
		/// CRF模板Id
        /// </summary>		
		private string _crf_group;
        [StringLength(100)]
        public string CRF_GROUP
        {
            get{ return _crf_group; }
            set{ _crf_group = value; }
        }        
		/// <summary>
		/// CRF模板名称
        /// </summary>		
		private string _crf_group_name;
        [StringLength(300)]
        public string CRF_GROUP_NAME
        {
            get{ return _crf_group_name; }
            set{ _crf_group_name = value; }
        }        
		/// <summary>
		/// 单位
        /// </summary>		
		private string _data_unit;
        [StringLength(100)]
        public string DATA_UNIT
        {
            get{ return _data_unit; }
            set{ _data_unit = value; }
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
        [StringLength(100)]
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


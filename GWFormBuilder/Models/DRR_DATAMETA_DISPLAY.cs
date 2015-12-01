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
		public class DRR_DATAMETA_DISPLAY
	{
   		     
      	/// <summary>
		/// 表示标示
        /// </summary>		
		private string _display_identity;
        [StringLength(100)]
        public string DISPLAY_IDENTITY
        {
            get{ return _display_identity; }
            set{ _display_identity = value; }
        }        
		/// <summary>
		/// 表示名称
        /// </summary>		
		private string _display_name;
        [StringLength(300)]
        public string DISPLAY_NAME
        {
            get{ return _display_name; }
            set{ _display_name = value; }
        }        
		/// <summary>
		/// 填报条目
        /// </summary>		
		private string _metaitem;
        [StringLength(300)]
        public string METAITEM
        {
            get{ return _metaitem; }
            set{ _metaitem = value; }
        }        
		/// <summary>
		/// 最大值
        /// </summary>		
		private string _max_value;
        [StringLength(50)]
        public string MAX_VALUE
        {
            get{ return _max_value; }
            set{ _max_value = value; }
        }        
		/// <summary>
		/// 最小值
        /// </summary>		
		private string _min_value;
        [StringLength(50)]
        public string MIN_VALUE
        {
            get{ return _min_value; }
            set{ _min_value = value; }
        }        
		/// <summary>
		/// 数据元值域表示格式DT，S
        /// </summary>		
		private string _data_meta_display;
        [StringLength(100)]
        public string DATA_META_DISPLAY
        {
            get{ return _data_meta_display; }
            set{ _data_meta_display = value; }
        }        
		/// <summary>
		/// 计量单位
        /// </summary>		
		private string _data_unit;
        [StringLength(50)]
        public string DATA_UNIT
        {
            get{ return _data_unit; }
            set{ _data_unit = value; }
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
		/// 类型标示 1text，3radio，2checkbox ,4select,5 img
        /// </summary>		
		private string _input_type;
        [StringLength(50)]
        public string INPUT_TYPE
        {
            get{ return _input_type; }
            set{ _input_type = value; }
        }        
		/// <summary>
		/// 数据元值的数据类型
        /// </summary>		
		private string _date_meta_type;
        [StringLength(50)]
        public string DATE_META_TYPE
        {
            get{ return _date_meta_type; }
            set{ _date_meta_type = value; }
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
		/// 表示类描述
        /// </summary>		
		private string _display_describe;
        [StringLength(500)]
        public string DISPLAY_DESCRIBE
        {
            get{ return _display_describe; }
            set{ _display_describe = value; }
        }        
		/// <summary>
		/// 状态 0可用 ，1审核，2合并，3删除
        /// </summary>		
		private string _status;
        [StringLength(10)]
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
        [StringLength(50)]
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


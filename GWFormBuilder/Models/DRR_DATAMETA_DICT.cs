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
		public class DRR_DATAMETA_DICT//数据元表
	{
   		     
      	/// <summary>
		/// 数据元标识码
        /// </summary>		
		private string _metadata_identify;
        [StringLength(50)]
        public string METADATA_IDENTIFY
        {
            get{ return _metadata_identify; }
            set{ _metadata_identify = value; }
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
		/// 数据元名称
        /// </summary>		
		private string _metadata_name;
        [StringLength(100)]
        public string METADATA_NAME
        {
            get{ return _metadata_name; }
            set{ _metadata_name = value; }
        }        
		/// <summary>
		/// 数据元类型编码
        /// </summary>		
		private string _metadatatype_code;
        [StringLength(50)]
        public string METADATATYPE_CODE
        {
            get{ return _metadatatype_code; }
            set{ _metadatatype_code = value; }
        }        
		/// <summary>
		/// 数据元值域类型
        /// </summary>		
		private string _metadatafield_type;
        [StringLength(100)]
        public string METADATAFIELD_TYPE
        {
            get{ return _metadatafield_type; }
            set{ _metadatafield_type = value; }
        }        
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
		/// 值域描述
        /// </summary>		
		private string _filed_describe;
        [StringLength(300)]
        public string FILED_DESCRIBE
        {
            get{ return _filed_describe; }
            set{ _filed_describe = value; }
        }        
		/// <summary>
		/// 数据元说明
        /// </summary>		
		private string _metadata_intro;
        [StringLength(300)]
        public string METADATA_INTRO
        {
            get{ return _metadata_intro; }
            set{ _metadata_intro = value; }
        }        
		/// <summary>
		/// 数据元英文名称
        /// </summary>		
		private string _metadata_egname;
        [StringLength(100)]
        public string METADATA_EGNAME
        {
            get{ return _metadata_egname; }
            set{ _metadata_egname = value; }
        }        
		/// <summary>
		/// SAS编码
        /// </summary>		
		private string _sas_code;
        [StringLength(100)]
        public string SAS_CODE
        {
            get{ return _sas_code; }
            set{ _sas_code = value; }
        }        
		/// <summary>
		/// 显示顺序
        /// </summary>		
		private Int16 _show_order;
        public Int16 SHOW_ORDER
        {
            get{ return _show_order; }
            set{ _show_order = value; }
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
        [StringLength(10)]
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
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
		/// 删除标记
        /// </summary>		
		private Int16 _del_flag;
        public Int16 DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// text，radio，checkbox 表单元素类型
        /// </summary>		
		private string _input_type;
        [StringLength(50)]
        public string INPUT_TYPE
        {
            get{ return _input_type; }
            set{ _input_type = value; }
        }        
		/// <summary>
		/// 完整名称
        /// </summary>		
		private string _completename;
        [StringLength(300)]
        public string COMPLETENAME
        {
            get{ return _completename; }
            set{ _completename = value; }
        }        
		/// <summary>
		/// 数据元关联
        /// </summary>		
		private string _relasionship_code;
        [StringLength(100)]
        public string RELASIONSHIP_CODE
        {
            get{ return _relasionship_code; }
            set{ _relasionship_code = value; }
        }        
		/// <summary>
		/// 分层结构
        /// </summary>		
		private string _prefix;
        [StringLength(500)]
        public string PREFIX
        {
            get{ return _prefix; }
            set{ _prefix = value; }
        }        
		/// <summary>
		/// 填报条目
        /// </summary>		
		private string _metaitem;
        [StringLength(500)]
        public string METAITEM
        {
            get{ return _metaitem; }
            set{ _metaitem = value; }
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
		/// 必填标记
        /// </summary>		
		private Int16 _mast_flag;
        public Int16 MAST_FLAG
        {
            get{ return _mast_flag; }
            set{ _mast_flag = value; }
        }        
		/// <summary>
		/// 父级标记
        /// </summary>		
		private string _father_flag;
        [StringLength(50)]
        public string FATHER_FLAG
        {
            get{ return _father_flag; }
            set{ _father_flag = value; }
        }        
		/// <summary>
		/// 效果数据元ID
        /// </summary>		
		private string _effect_datameta;
        [StringLength(100)]
        public string EFFECT_DATAMETA
        {
            get{ return _effect_datameta; }
            set{ _effect_datameta = value; }
        }        
		/// <summary>
		/// 效果值域value
        /// </summary>		
		private string _effect_flag;
        [StringLength(100)]
        public string EFFECT_FLAG
        {
            get{ return _effect_flag; }
            set{ _effect_flag = value; }
        }        
		/// <summary>
		/// 最大值
        /// </summary>		
		private string _max_value;
        [StringLength(100)]
        public string MAX_VALUE
        {
            get{ return _max_value; }
            set{ _max_value = value; }
        }        
		/// <summary>
		/// 最小值
        /// </summary>		
		private string _min_value;
        [StringLength(100)]
        public string MIN_VALUE
        {
            get{ return _min_value; }
            set{ _min_value = value; }
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
		/// <summary>
		/// 数据元类型（0通用，1特种疾病）
        /// </summary>		
		private string _data_meta_type;
        [StringLength(20)]
        public string DATA_META_TYPE
        {
            get{ return _data_meta_type; }
            set{ _data_meta_type = value; }
        }        
		/// <summary>
		/// 数据元匹配的正则表达式
        /// </summary>		
		private string _data_meta_regular;
        [StringLength(300)]
        public string DATA_META_REGULAR
        {
            get{ return _data_meta_regular; }
            set{ _data_meta_regular = value; }
        }        
		/// <summary>
		/// 数据元值得数据类型
        /// </summary>		
		private string _data_meta_datatype;
        [StringLength(100)]
        public string DATA_META_DATATYPE
        {
            get{ return _data_meta_datatype; }
            set{ _data_meta_datatype = value; }
        }        
		/// <summary>
		/// 数据元值字母标示DT, D
        /// </summary>		
		private string _data_meta_display;
        [StringLength(100)]
        public string DATA_META_DISPLAY
        {
            get{ return _data_meta_display; }
            set{ _data_meta_display = value; }
        }        
		/// <summary>
		/// 数据元允许值
        /// </summary>		
		private string _data_meta_value;
        [StringLength(100)]
        public string DATA_META_VALUE
        {
            get{ return _data_meta_value; }
            set{ _data_meta_value = value; }
        }        
		/// <summary>
		/// 数据元来源
        /// </summary>		
		private string _datameta_from;
        [StringLength(100)]
        public string DATAMETA_FROM
        {
            get{ return _datameta_from; }
            set{ _datameta_from = value; }
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
		/// 对象类代码
        /// </summary>		
		private string _data_object_id;
        [StringLength(100)]
        public string DATA_OBJECT_ID
        {
            get{ return _data_object_id; }
            set{ _data_object_id = value; }
        }        
		/// <summary>
		/// 特性类代码
        /// </summary>		
		private string _data_feature_id;
        [StringLength(100)]
        public string DATA_FEATURE_ID
        {
            get{ return _data_feature_id; }
            set{ _data_feature_id = value; }
        }        
		/// <summary>
		/// 表示类代码
        /// </summary>		
		private string _data_display_id;
        [StringLength(100)]
        public string DATA_DISPLAY_ID
        {
            get{ return _data_display_id; }
            set{ _data_display_id = value; }
        }        
		/// <summary>
		/// 数据元编码前缀 JH
        /// </summary>		
		private string _data_meta_prefix;
        [StringLength(300)]
        public string DATA_META_PREFIX
        {
            get{ return _data_meta_prefix; }
            set{ _data_meta_prefix = value; }
        }        
		/// <summary>
		/// 对象类名称
        /// </summary>		
		private string _data_object_name;
        [StringLength(300)]
        public string DATA_OBJECT_NAME
        {
            get{ return _data_object_name; }
            set{ _data_object_name = value; }
        }        
		/// <summary>
		/// 表示类名称
        /// </summary>		
		private string _data_display;
        [StringLength(300)]
        public string DATA_DISPLAY
        {
            get{ return _data_display; }
            set{ _data_display = value; }
        }        
		/// <summary>
		/// 值域名称
        /// </summary>		
		private string _metadatafield_name;
        [StringLength(300)]
        public string METADATAFIELD_NAME
        {
            get{ return _metadatafield_name; }
            set{ _metadatafield_name = value; }
        }        
		/// <summary>
		/// 特性类名称
        /// </summary>		
		private string _data_feature_name;
        [StringLength(300)]
        public string DATA_FEATURE_NAME
        {
            get{ return _data_feature_name; }
            set{ _data_feature_name = value; }
        }        
		/// <summary>
		/// 所属数据集
        /// </summary>		
		private string _dataset_id;
        [StringLength(50)]
        public string DATASET_ID
        {
            get{ return _dataset_id; }
            set{ _dataset_id = value; }
        }        
		/// <summary>
		/// 数据集名称
        /// </summary>		
		private string _dataset_name;
        [StringLength(200)]
        public string DATASET_NAME
        {
            get{ return _dataset_name; }
            set{ _dataset_name = value; }
        }        
		/// <summary>
		/// 默认排序
        /// </summary>		
		private Int16 _shor_order;
        public Int16 SHOR_ORDER
        {
            get{ return _shor_order; }
            set{ _shor_order = value; }
        }        
		/// <summary>
		/// 主键
        /// </summary>		
		private Int16 _metaid;
        public Int16 METAID
        {
            get{ return _metaid; }
            set{ _metaid = value; }
        }        
		/// <summary>
		/// 最大长度
        /// </summary>		
		private Int16 _maxlength;
        public Int16 MAXLENGTH
        {
            get{ return _maxlength; }
            set{ _maxlength = value; }
        }        
		/// <summary>
		/// 最小长度
        /// </summary>		
		private Int16 _minlength;
        public Int16 MINLENGTH
        {
            get{ return _minlength; }
            set{ _minlength = value; }
        }        
		/// <summary>
		/// 整数位数
        /// </summary>		
		private Int16 _int_num;
        public Int16 INT_NUM
        {
            get{ return _int_num; }
            set{ _int_num = value; }
        }        
		/// <summary>
		/// 小数位数
        /// </summary>		
		private Int16 _Int16_num;
        public Int16 Int16_NUM
        {
            get{ return _Int16_num; }
            set{ _Int16_num = value; }
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
        /// 病种编码
        /// </summary>		
        private string _disease_id;
        [StringLength(50)]
        public string DISEASE_ID
        {
            get { return _disease_id; }
            set { _disease_id = value; }
        }
    }
}


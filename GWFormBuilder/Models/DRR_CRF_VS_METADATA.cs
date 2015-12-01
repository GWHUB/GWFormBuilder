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
		public class DRR_CRF_VS_METADATA
	{
   		     
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
		/// 课题病种编码
        /// </summary>		
		private string _subject_id;
        [StringLength(50)]
        public string SUBJECT_ID
        {
            get{ return _subject_id; }
            set{ _subject_id = value; }
        }        
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
		/// 模板名称
        /// </summary>		
		private string _template_name;
        [StringLength(50)]
        public string TEMPLATE_NAME
        {
            get{ return _template_name; }
            set{ _template_name = value; }
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
		/// 数据元表示符
        /// </summary>		
		private string _metadata_identify;
        [StringLength(100)]
        public string METADATA_IDENTIFY
        {
            get{ return _metadata_identify; }
            set{ _metadata_identify = value; }
        }        
		/// <summary>
		/// 0-text，1-radio，2-CheckBox 
        /// </summary>		
		private string _input_type;
        [StringLength(50)]
        public string INPUT_TYPE
        {
            get{ return _input_type; }
            set{ _input_type = value; }
        }        
		/// <summary>
		/// 数据元名称
        /// </summary>		
		private string _datametaname;
        [StringLength(100)]
        public string DATAMETANAME
        {
            get{ return _datametaname; }
            set{ _datametaname = value; }
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
		/// 填报条目
        /// </summary>		
		private string _prefix;
        [StringLength(300)]
        public string PREFIX
        {
            get{ return _prefix; }
            set{ _prefix = value; }
        }        
		/// <summary>
		/// 值域代码
        /// </summary>		
		private string _fieldcode_tablecode;
        [StringLength(100)]
        public string FIELDCODE_TABLECODE
        {
            get{ return _fieldcode_tablecode; }
            set{ _fieldcode_tablecode = value; }
        }        
		/// <summary>
		/// 数据元值得数据类型 S1,N,S,S3,D,DM,DT,T
        /// </summary>		
		private string _date_meta_type;
        [StringLength(50)]
        public string DATE_META_TYPE
        {
            get{ return _date_meta_type; }
            set{ _date_meta_type = value; }
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
		/// 版本
        /// </summary>		
		private string _version;
        [StringLength(50)]
        public string VERSION
        {
            get{ return _version; }
            set{ _version = value; }
        }        
		/// <summary>
		/// 版本时间
        /// </summary>		
		private DateTime _version_date;
        public DateTime VERSION_DATE
        {
            get{ return _version_date; }
            set{ _version_date = value; }
        }        
		/// <summary>
		/// 必填标记1 必填 0 非
        /// </summary>		
		private string _mast_flag;
        [StringLength(10)]
        public string MAST_FLAG
        {
            get{ return _mast_flag; }
            set{ _mast_flag = value; }
        }        
		/// <summary>
		/// 父级标记 0非 1为父级数据元
        /// </summary>		
		private string _father_flag;
        [StringLength(10)]
        public string FATHER_FLAG
        {
            get{ return _father_flag; }
            set{ _father_flag = value; }
        }        
		/// <summary>
		/// 最大值
        /// </summary>		
		private string _max_value;
       [StringLength(20)]
        public string MAX_VALUE
        {
            get{ return _max_value; }
            set{ _max_value = value; }
        }        
		/// <summary>
		/// 最小值
        /// </summary>		
		private string _min_value;
        [StringLength(20)]
        public string MIN_VALUE
        {
            get{ return _min_value; }
            set{ _min_value = value; }
        }        
		/// <summary>
		/// 最大长度
        /// </summary>		
		private string _max_length;
        [StringLength(20)]
        public string MAX_LENGTH
        {
            get{ return _max_length; }
            set{ _max_length = value; }
        }        
		/// <summary>
		/// 最小长度
        /// </summary>		
		private string _min_length;
        [StringLength(20)]
        public string MIN_LENGTH
        {
            get{ return _min_length; }
            set{ _min_length = value; }
        }        
		/// <summary>
		/// 数据元匹配的正则表达式
        /// </summary>		
		private string _reg_text;
        [StringLength(200)]
        public string REG_TEXT
        {
            get{ return _reg_text; }
            set{ _reg_text = value; }
        }        
		/// <summary>
		/// 父级数据元编码
        /// </summary>		
		private string _parent_id;
        [StringLength(100)]
        public string PARENT_ID
        {
            get{ return _parent_id; }
            set{ _parent_id = value; }
        }        
		/// <summary>
		/// 父级数据元的值域value 当父级数据元的值域为此值时出现子数据元
        /// </summary>		
		private string _fieldvalue;
        [StringLength(100)]
        public string FIELDVALUE
        {
            get{ return _fieldvalue; }
            set{ _fieldvalue = value; }
        }        
		/// <summary>
		/// 跨表单关联数据元内部表示编码
        /// </summary>		
		private string _jumprelationmetainnerid;
        [StringLength(100)]
        public string JUMPRELATIONMETAINNERID
        {
            get{ return _jumprelationmetainnerid; }
            set{ _jumprelationmetainnerid = value; }
        }        
		/// <summary>
		/// 是否父级数据元 0否 1是(此属性控制树形关系 )
        /// </summary>		
		private string _is_father;
        [StringLength(10)]
        public string IS_FATHER
        {
            get{ return _is_father; }
            set{ _is_father = value; }
        }        
		/// <summary>
		/// 是否是计算数据元0否 1是
        /// </summary>		
		private string _is_compute;
        [StringLength(10)]
        public string IS_COMPUTE
        {
            get{ return _is_compute; }
            set{ _is_compute = value; }
        }        
		/// <summary>
		/// 是否是结果数据元0否 1是
        /// </summary>		
		private string _is_result;
        [StringLength(10)]
        public string IS_RESULT
        {
            get{ return _is_result; }
            set{ _is_result = value; }
        }        
		/// <summary>
		/// 计算值
        /// </summary>		
		private string _compute_value;
        [StringLength(10)]
        public string COMPUTE_VALUE
        {
            get{ return _compute_value; }
            set{ _compute_value = value; }
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
		/// 数据元显示宽度
        /// </summary>		
		private string _column_width;
        [StringLength(100)]
        public string COLUMN_WIDTH
        {
            get{ return _column_width; }
            set{ _column_width = value; }
        }        
		/// <summary>
		/// 执行的方法的名称
        /// </summary>		
		private string _funstr;
        [StringLength(100)]
        public string FUNSTR
        {
            get{ return _funstr; }
            set{ _funstr = value; }
        }        
		/// <summary>
		/// 表格ID
        /// </summary>		
		private string _tab_id;
        [StringLength(50)]
        public string TAB_ID
        {
            get{ return _tab_id; }
            set{ _tab_id = value; }
        }        
		/// <summary>
		/// 所在行
        /// </summary>		
		private string _row_id;
        [StringLength(50)]
        public string ROW_ID
        {
            get{ return _row_id; }
            set{ _row_id = value; }
        }        
		/// <summary>
		/// 所在列
        /// </summary>		
		private string _col_id;
        [StringLength(50)]
        public string COL_ID
        {
            get{ return _col_id; }
            set{ _col_id = value; }
        }        
		/// <summary>
		/// 提示信息
        /// </summary>		
		private string _suggestion;
        [StringLength(100)]
        public string SUGGESTION
        {
            get{ return _suggestion; }
            set{ _suggestion = value; }
        }        
		/// <summary>
		/// 与父级连接字符
        /// </summary>		
		private string _father_connectstr;
        [StringLength(300)]
        public string FATHER_CONNECTSTR
        {
            get{ return _father_connectstr; }
            set{ _father_connectstr = value; }
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
		/// 数据元排列顺序
        /// </summary>		
		private Int16 _show_order;
        public Int16 SHOW_ORDER
        {
            get{ return _show_order; }
            set{ _show_order = value; }
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
		/// CRF版本号
        /// </summary>		
		private string _crf_version;
        [StringLength(50)]
        public string CRF_VERSION
        {
            get{ return _crf_version; }
            set{ _crf_version = value; }
        }        
		/// <summary>
		/// CRF版本时间
        /// </summary>		
		private DateTime _crf_versiondate;
        public DateTime CRF_VERSIONDATE
        {
            get{ return _crf_versiondate; }
            set{ _crf_versiondate = value; }
        }        
		/// <summary>
		/// 表现形式。表格如果是表格tab_2_0_1 一般形式则为空 comm table h1,h2,h3 h4,
        /// </summary>		
		private string _displaytype;
        [StringLength(50)]
        public string DISPLAYTYPE
        {
            get{ return _displaytype; }
            set{ _displaytype = value; }
        }        
		/// <summary>
		/// DATAMETA_ACTION？
        /// </summary>		
		private string _datameta_action;
        [StringLength(50)]
        public string DATAMETA_ACTION
        {
            get{ return _datameta_action; }
            set{ _datameta_action = value; }
        }        
		/// <summary>
		/// FATHER_RELATION
        /// </summary>		
		private string _father_relation;
        [StringLength(50)]
        public string FATHER_RELATION
        {
            get{ return _father_relation; }
            set{ _father_relation = value; }
        }        
		/// <summary>
		/// FATHERDE
        /// </summary>		
		private string _fatherde;
        [StringLength(50)]
        public string FATHERDE
        {
            get{ return _fatherde; }
            set{ _fatherde = value; }
        }        
		/// <summary>
		/// COL_NUM
        /// </summary>		
		private string _col_num;
        [StringLength(50)]
        public string COL_NUM
        {
            get{ return _col_num; }
            set{ _col_num = value; }
        }        
		/// <summary>
		/// ROW_NUM
        /// </summary>		
		private string _row_num;
        [StringLength(50)]
        public string ROW_NUM
        {
            get{ return _row_num; }
            set{ _row_num = value; }
        }        
		/// <summary>
		/// 前缀显示
        /// </summary>		
		private string _prefixion;
        [StringLength(100)]
        public string PREFIXION
        {
            get{ return _prefixion; }
            set{ _prefixion = value; }
        }        
		/// <summary>
		/// js方法名称
        /// </summary>		
		private string _js_funstr;
        [StringLength(200)]
        public string JS_FUNSTR
        {
            get{ return _js_funstr; }
            set{ _js_funstr = value; }
        }        
		/// <summary>
		/// 规则库描述
        /// </summary>		
		private string _rulexml;
        public  string  RULEXML
        {
            get{ return _rulexml; }
            set{ _rulexml = value; }
        }        
		/// <summary>
		/// 控件编码
        /// </summary>		
		private string _conctrolid;
        [StringLength(50)]
        public string CONCTROLID
        {
            get{ return _conctrolid; }
            set{ _conctrolid = value; }
        }        
		/// <summary>
		/// 是否是数据元 0否1 是
        /// </summary>		
		private string _ismeta;
        [StringLength(20)]
        public string ISMETA
        {
            get{ return _ismeta; }
            set{ _ismeta = value; }
        }        
		   
	}
}


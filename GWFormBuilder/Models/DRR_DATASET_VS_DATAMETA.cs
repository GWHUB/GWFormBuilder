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
		public class DRR_DATASET_VS_DATAMETA
	{
   		     
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
		/// 数据元标识编码
        /// </summary>		
		private string _metadata_identify;
        [StringLength(100)]
        public string METADATA_IDENTIFY
        {
            get{ return _metadata_identify; }
            set{ _metadata_identify = value; }
        }        
		/// <summary>
		/// 值域表单
        /// </summary>		
		private string _fieldcode_tablecode;
        [StringLength(300)]
        public string FIELDCODE_TABLECODE
        {
            get{ return _fieldcode_tablecode; }
            set{ _fieldcode_tablecode = value; }
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
		/// 重复次数
        /// </summary>		
		private Int16 _repeat_count;
        public Int16 REPEAT_COUNT
        {
            get{ return _repeat_count; }
            set{ _repeat_count = value; }
        }        
		/// <summary>
		/// 强制标志
        /// </summary>		
		private Int16 _force_flag;
        public Int16 FORCE_FLAG
        {
            get{ return _force_flag; }
            set{ _force_flag = value; }
        }        
		/// <summary>
		/// 录入提示
        /// </summary>		
		private string _suggestion;
        [StringLength(300)]
        public string SUGGESTION
        {
            get{ return _suggestion; }
            set{ _suggestion = value; }
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
		/// 显示顺序
        /// </summary>		
		private Int16 _show_order;
        public Int16 SHOW_ORDER
        {
            get{ return _show_order; }
            set{ _show_order = value; }
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
		/// 数据元关联
        /// </summary>		
		private string _datameta_relevance;
        [StringLength(100)]
        public string DATAMETA_RELEVANCE
        {
            get{ return _datameta_relevance; }
            set{ _datameta_relevance = value; }
        }        
		/// <summary>
		/// 父级嵌套关系或位置 c在父数据元后面，数字时等于该值时显示
        /// </summary>		
		private string _father_relation;
        [StringLength(100)]
        public string FATHER_RELATION
        {
            get{ return _father_relation; }
            set{ _father_relation = value; }
        }        
		/// <summary>
		/// 与父级连接字符
        /// </summary>		
		private string _father_connectstr;
        [StringLength(100)]
        public string FATHER_CONNECTSTR
        {
            get{ return _father_connectstr; }
            set{ _father_connectstr = value; }
        }        
		/// <summary>
		/// 标签显示内容
        /// </summary>		
		private string _laberl_content;
        [StringLength(300)]
        public string LABERL_CONTENT
        {
            get{ return _laberl_content; }
            set{ _laberl_content = value; }
        }        
		/// <summary>
		/// 数据元交互
        /// </summary>		
		private string _datameta_interactive;
        [StringLength(100)]
        public string DATAMETA_INTERACTIVE
        {
            get{ return _datameta_interactive; }
            set{ _datameta_interactive = value; }
        }        
		/// <summary>
		/// 0,必填，1选填
        /// </summary>		
		private string _mast_flag;
        [StringLength(20)]
        public string MAST_FLAG
        {
            get{ return _mast_flag; }
            set{ _mast_flag = value; }
        }        
		/// <summary>
		/// 数据元组id标示
        /// </summary>		
		private string _data_group_id;
        [StringLength(50)]
        public string DATA_GROUP_ID
        {
            get{ return _data_group_id; }
            set{ _data_group_id = value; }
        }        
		/// <summary>
		/// 是否是父数据元 0否 1是
        /// </summary>		
		private string _is_father;
        [StringLength(20)]
        public string IS_FATHER
        {
            get{ return _is_father; }
            set{ _is_father = value; }
        }        
		/// <summary>
		/// 是否是计算数据元 0否 1是
        /// </summary>		
		private string _is_compute;
        [StringLength(20)]
        public string IS_COMPUTE
        {
            get{ return _is_compute; }
            set{ _is_compute = value; }
        }        
		/// <summary>
		/// 是否总分数据元
        /// </summary>		
		private string _is_result;
        [StringLength(20)]
        public string IS_RESULT
        {
            get{ return _is_result; }
            set{ _is_result = value; }
        }        
		/// <summary>
		/// 数据元动作处理的函数１，隐藏，0 显示 ,2 插入 6加7 减
        /// </summary>		
		private string _datameta_action;
        [StringLength(20)]
        public string DATAMETA_ACTION
        {
            get{ return _datameta_action; }
            set{ _datameta_action = value; }
        }        
		/// <summary>
		/// 最大值
        /// </summary>		
		private Int16 _max_value;
        public Int16 MAX_VALUE
        {
            get{ return _max_value; }
            set{ _max_value = value; }
        }        
		/// <summary>
		/// 最小值
        /// </summary>		
		private Int16 _min_value;
        public Int16 MIN_VALUE
        {
            get{ return _min_value; }
            set{ _min_value = value; }
        }        
		/// <summary>
		/// 最大长度
        /// </summary>		
		private Int16 _max_length;
        public Int16 MAX_LENGTH
        {
            get{ return _max_length; }
            set{ _max_length = value; }
        }        
		/// <summary>
		/// 最小长度
        /// </summary>		
		private Int16 _min_length;
        public Int16 MIN_LENGTH
        {
            get{ return _min_length; }
            set{ _min_length = value; }
        }        
		/// <summary>
		/// 表现形式。表格如果是表格tab_2_0_1 一般形式则为空 comm table h1,h2,h3 h4,
        /// </summary>		
		private string _displaytype;
        [StringLength(100)]
        public string DISPLAYTYPE
        {
            get{ return _displaytype; }
            set{ _displaytype = value; }
        }        
		/// <summary>
		/// 跨表单关联数据元内部标识码
        /// </summary>		
		private string _jumprelationmetainnerid;
        [StringLength(100)]
        public string JUMPRELATIONMETAINNERID
        {
            get{ return _jumprelationmetainnerid; }
            set{ _jumprelationmetainnerid = value; }
        }        
		/// <summary>
		/// 数据元匹配的正则表达式
        /// </summary>		
		private string _reg_text;
        [StringLength(500)]
        public string REG_TEXT
        {
            get{ return _reg_text; }
            set{ _reg_text = value; }
        }        
		/// <summary>
		/// 表格ID
        /// </summary>		
		private string _tab_id;
        [StringLength(100)]
        public string TAB_ID
        {
            get{ return _tab_id; }
            set{ _tab_id = value; }
        }        
		/// <summary>
		/// 行编号
        /// </summary>		
		private string _row_num;
        [StringLength(100)]
        public string ROW_NUM
        {
            get{ return _row_num; }
            set{ _row_num = value; }
        }        
		/// <summary>
		/// 列编号
        /// </summary>		
		private string _col_num;
        [StringLength(100)]
        public string COL_NUM
        {
            get{ return _col_num; }
            set{ _col_num = value; }
        }        
		/// <summary>
		/// 父数据元编码
        /// </summary>		
		private string _parent_id;
        [StringLength(100)]
        public string PARENT_ID
        {
            get{ return _parent_id; }
            set{ _parent_id = value; }
        }        
		/// <summary>
		/// 值域value
        /// </summary>		
		private string _fieldvalue;
        [StringLength(100)]
        public string FIELDVALUE
        {
            get{ return _fieldvalue; }
            set{ _fieldvalue = value; }
        }        
		/// <summary>
		/// 类型标示 text,radio,checkbox，select, img select2 table 
        /// </summary>		
		private string _input_type;
        [StringLength(100)]
        public string INPUT_TYPE
        {
            get{ return _input_type; }
            set{ _input_type = value; }
        }        
		/// <summary>
		/// 单位
        /// </summary>		
		private string _data_unit;
        [StringLength(50)]
        public string DATA_UNIT
        {
            get{ return _data_unit; }
            set{ _data_unit = value; }
        }        
		/// <summary>
		/// 计算值域
        /// </summary>		
		private string _compute_value;
        [StringLength(50)]
        public string COMPUTE_VALUE
        {
            get{ return _compute_value; }
            set{ _compute_value = value; }
        }        
		/// <summary>
		/// 整数位数
        /// </summary>		
		private Int16 _int_num;
        [StringLength(50)]
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
        [StringLength(500)]
        public string FUNSTR
        {
            get{ return _funstr; }
            set{ _funstr = value; }
        }        
		/// <summary>
		/// 所在行
        /// </summary>		
		private string _row_id;
        [StringLength(100)]
        public string ROW_ID
        {
            get{ return _row_id; }
            set{ _row_id = value; }
        }        
		/// <summary>
		/// 所在列
        /// </summary>		
		private string _col_id;
        [StringLength(100)]
        public string COL_ID
        {
            get{ return _col_id; }
            set{ _col_id = value; }
        }        
		/// <summary>
		/// 前缀显示
        /// </summary>		
		private string _prefixion;
        [StringLength(500)]
        public string PREFIXION
        {
            get{ return _prefixion; }
            set{ _prefixion = value; }
        }        
		/// <summary>
		/// 组件编码
        /// </summary>		
		private string _conctrolid;
        [StringLength(100)]
        public string CONCTROLID
        {
            get{ return _conctrolid; }
            set{ _conctrolid = value; }
        }        
		/// <summary>
		/// 数据元值的数据类型
        /// </summary>		
		private string _data_meta_datatype;
        [StringLength(100)]
        public string DATA_META_DATATYPE
        {
            get{ return _data_meta_datatype; }
            set{ _data_meta_datatype = value; }
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
		/// <summary>
		/// --填报条目字体大小--
        /// </summary>		
		private Int16 _prefix_fontsize;
        public Int16 PREFIX_FONTSIZE
        {
            get{ return _prefix_fontsize; }
            set{ _prefix_fontsize = value; }
        }        
		/// <summary>
		/// --填报条目背景颜色--
        /// </summary>		
		private string _prefix_back_color;
        [StringLength(100)]
        public string PREFIX_BACK_COLOR
        {
            get{ return _prefix_back_color; }
            set{ _prefix_back_color = value; }
        }        
		/// <summary>
		/// 填报条目对齐方式 0 左对齐，1右对齐 2 居中
        /// </summary>		
		private string _prefix_aligntype;
        [StringLength(20)]
        public string PREFIX_ALIGNTYPE
        {
            get{ return _prefix_aligntype; }
            set{ _prefix_aligntype = value; }
        }        
		/// <summary>
		/// 所属 数据元组-
        /// </summary>		
		private string _groupid;
        [StringLength(100)]
        public string GROUPID
        {
            get{ return _groupid; }
            set{ _groupid = value; }
        }        
		/// <summary>
		/// 值域排序方式0 横排，1 竖排
        /// </summary>		
		private Int16 _field_sortord;
        public Int16 FIELD_SORTORD
        {
            get{ return _field_sortord; }
            set{ _field_sortord = value; }
        }        
		/// <summary>
		/// 所占行数
        /// </summary>		
		private Int16 _rowspan;
        public Int16 ROWSPAN
        {
            get{ return _rowspan; }
            set{ _rowspan = value; }
        }        
		/// <summary>
		/// 所占列数
        /// </summary>		
		private Int16 _colspan;
        public Int16 COLSPAN
        {
            get{ return _colspan; }
            set{ _colspan = value; }
        }        
		/// <summary>
		/// 双值域（如果有值，则表示这个数据元有两个值域，一个文本类型，一个值域类型）
        /// </summary>		
		private string _doublefiled;
        [StringLength(50)]
        public string DOUBLEFILED
        {
            get{ return _doublefiled; }
            set{ _doublefiled = value; }
        }        
		/// <summary>
		/// 上表字符
        /// </summary>		
		private string _sup_str;
        [StringLength(100)]
        public string SUP_STR
        {
            get{ return _sup_str; }
            set{ _sup_str = value; }
        }        
		/// <summary>
		/// 下标字符
        /// </summary>		
		private string _sub_str;
        [StringLength(100)]
        public string SUB_STR
        {
            get{ return _sub_str; }
            set{ _sub_str = value; }
        }        
		/// <summary>
		/// 数据元层级（用GROUPID 和层级表示这个数据元的层级关系例如诊断分级，和省市县）
        /// </summary>		
		private string _meta_tier;
        [StringLength(100)]
        public string META_TIER
        {
            get{ return _meta_tier; }
            set{ _meta_tier = value; }
        }        
		/// <summary>
		/// 填报条目字体
        /// </summary>		
		private string _prefix_font_name;
        [StringLength(100)]
        public string PREFIX_FONT_NAME
        {
            get{ return _prefix_font_name; }
            set{ _prefix_font_name = value; }
        }        
		/// <summary>
		/// 填报条目前景色
        /// </summary>		
		private string _prefix_for_color;
        [StringLength(100)]
        public string PREFIX_FOR_COLOR
        {
            get{ return _prefix_for_color; }
            set{ _prefix_for_color = value; }
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


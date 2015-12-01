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
		public class DRR_DATASET_DICT
	{
   		     
      	/// <summary>
		/// 一级类目
        /// </summary>		
		private string _first_catalog;
        [StringLength(100)]
        public string FIRST_CATALOG
        {
            get{ return _first_catalog; }
            set{ _first_catalog = value; }
        }        
		/// <summary>
		/// 二级类目
        /// </summary>		
		private string _second_catalog;
        [StringLength(100)]
        public string SECOND_CATALOG
        {
            get{ return _second_catalog; }
            set{ _second_catalog = value; }
        }        
		/// <summary>
		/// 数据集标准名称
        /// </summary>		
		private string _dataset_name;
        [StringLength(200)]
        public string DATASET_NAME
        {
            get{ return _dataset_name; }
            set{ _dataset_name = value; }
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
		/// 显示顺序
        /// </summary>		
		private Int16 _show_order;
        public Int16 SHOW_ORDER
        {
            get{ return _show_order; }
            set{ _show_order = value; }
        }        
		/// <summary>
		/// 数据集发布方
        /// </summary>		
		private string _dataset_public_organize;
        [StringLength(100)]
        public string DATASET_PUBLIC_ORGANIZE
        {
            get{ return _dataset_public_organize; }
            set{ _dataset_public_organize = value; }
        }        
		/// <summary>
		/// 关键词
        /// </summary>		
		private string _key_word;
        [StringLength(100)]
        public string KEY_WORD
        {
            get{ return _key_word; }
            set{ _key_word = value; }
        }        
		/// <summary>
		/// 数据集语种
        /// </summary>		
		private string _dataset_lanuage;
        [StringLength(100)]
        public string DATASET_LANUAGE
        {
            get{ return _dataset_lanuage; }
            set{ _dataset_lanuage = value; }
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
		/// 状态
        /// </summary>		
		private Int16 _status;
        public Int16 STATUS
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
		/// 三级类目
        /// </summary>		
		private string _third_catalog;
        [StringLength(100)]
        public string THIRD_CATALOG
        {
            get{ return _third_catalog; }
            set{ _third_catalog = value; }
        }        
		/// <summary>
		/// 四级类目
        /// </summary>		
		private string _fourth_catalog;
        [StringLength(100)]
        public string FOURTH_CATALOG
        {
            get{ return _fourth_catalog; }
            set{ _fourth_catalog = value; }
        }        
		/// <summary>
		/// 所属项目 0,为共享，其他数字代表所属疾病的id
        /// </summary>		
		private string _project_id;
        [StringLength(50)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// 数据集html内容关联id
        /// </summary>		
		private string _content_id;
        [StringLength(100)]
        public string CONTENT_ID
        {
            get{ return _content_id; }
            set{ _content_id = value; }
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
		/// 简介
        /// </summary>		
		private string _dataset_info;
        [StringLength(300)]
        public string DATASET_INFO
        {
            get{ return _dataset_info; }
            set{ _dataset_info = value; }
        }        
		/// <summary>
		/// 编辑内容XMl
        /// </summary>		
		private string _editedxmlcontent;
        public string EDITEDXMLCONTENT
        {
            get{ return _editedxmlcontent; }
            set{ _editedxmlcontent = value; }
        }        
		/// <summary>
		/// 查看内容XMl
        /// </summary>		
		private string  _viewxmlcontent;
        public string  VIEWXMLCONTENT
        {
            get{ return _viewxmlcontent; }
            set{ _viewxmlcontent = value; }
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
		/// 数据集显示内容
        /// </summary>		
		private string  _showhtmlstr;
        public string  SHOWHTMLSTR
        {
            get{ return _showhtmlstr; }
            set{ _showhtmlstr = value; }
        }        
		/// <summary>
		/// 是否显示填报条目的前缀 0是 1 否
        /// </summary>		
		private Int16 _show_prefixon_flag;
        public Int16 SHOW_PREFIXON_FLAG
        {
            get{ return _show_prefixon_flag; }
            set{ _show_prefixon_flag = value; }
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


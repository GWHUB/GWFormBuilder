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
		public class DRR_CRF_TEMPLET
	{
   		     
      	/// <summary>
		/// ��Ŀ���
        /// </summary>		
		private string _project_id;
        [StringLength(50)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// ģ����
        /// </summary>		
		private string _templet_id;
        [StringLength(50)]
        public string TEMPLET_ID
        {
            get{ return _templet_id; }
            set{ _templet_id = value; }
        }        
		/// <summary>
		/// ģ������
        /// </summary>		
		private string _templet_name;
        [StringLength(100)]
        public string TEMPLET_NAME
        {
            get{ return _templet_name; }
            set{ _templet_name = value; }
        }        
		/// <summary>
		/// ģ�������
        /// </summary>		
		private string _templet_sub_id;
        [StringLength(50)]
        public string TEMPLET_SUB_ID
        {
            get{ return _templet_sub_id; }
            set{ _templet_sub_id = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private DateTime _create_time;
        public DateTime CREATE_TIME
        {
            get{ return _create_time; }
            set{ _create_time = value; }
        }        
		/// <summary>
		/// ������
        /// </summary>		
		private string _create_man;
        [StringLength(100)]
        public string CREATE_MAN
        {
            get{ return _create_man; }
            set{ _create_man = value; }
        }        
		/// <summary>
		/// �汾��
        /// </summary>		
		private string _vision_id;
        [StringLength(50)]
        public string VISION_ID
        {
            get{ return _vision_id; }
            set{ _vision_id = value; }
        }        
		/// <summary>
		/// ģ��״̬0���� 1���ã�2�Ƴ���3,ɾ��
        /// </summary>		
		private Int16 _templet_status;
        public Int16 TEMPLET_STATUS
        {
            get{ return _templet_status; }
            set{ _templet_status = value; }
        }        
		/// <summary>
		/// ʱ���
        /// </summary>		
		private DateTime _timestamp;
        public DateTime TIMESTAMP
        {
            get{ return _timestamp; }
            set{ _timestamp = value; }
        }        
		/// <summary>
		/// ɾ�����
        /// </summary>		
		private Int16 _del_flag;
        public Int16 DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// CRF����
        /// </summary>		
		private string _crf_class;
        [StringLength(50)]
        public string CRF_CLASS
        {
            get{ return _crf_class; }
            set{ _crf_class = value; }
        }        
		/// <summary>
		/// �Ƿ���ʾ
        /// </summary>		
		private Int16 _visibled;
        public Int16 VISIBLED
        {
            get{ return _visibled; }
            set{ _visibled = value; }
        }        
		/// <summary>
		/// ��ʾ˳��
        /// </summary>		
		private Int16 _show_order;
        public Int16 SHOW_ORDER
        {
            get{ return _show_order; }
            set{ _show_order = value; }
        }        
		/// <summary>
		/// ƴ����
        /// </summary>		
		private string _input_code;
        [StringLength(100)]
        public string INPUT_CODE
        {
            get{ return _input_code; }
            set{ _input_code = value; }
        }        
		/// <summary>
		/// ģ��·��
        /// </summary>		
		private string _templet_path;
        [StringLength(100)]
        public string TEMPLET_PATH
        {
            get{ return _templet_path; }
            set{ _templet_path = value; }
        }        
		/// <summary>
		/// �������ݼ�
        /// </summary>		
		private string _templet_intro;
        [StringLength(200)]
        public string TEMPLET_INTRO
        {
            get{ return _templet_intro; }
            set{ _templet_intro = value; }
        }        
		/// <summary>
		/// ��������ID
        /// </summary>		
		private string _dataset_code;
        [StringLength(50)]
        public string DATASET_CODE
        {
            get{ return _dataset_code; }
            set{ _dataset_code = value; }
        }        
		/// <summary>
		/// �ظ����
        /// </summary>		
		private string _control_second_id;
        [StringLength(100)]
        public string CONTROL_SECOND_ID
        {
            get{ return _control_second_id; }
            set{ _control_second_id = value; }
        }        
		/// <summary>
		/// ģ����
        /// </summary>		
		private Int16 _repeat_flag;
        public Int16 REPEAT_FLAG
        {
            get{ return _repeat_flag; }
            set{ _repeat_flag = value; }
        }        
		/// <summary>
		/// �汾ʱ��
        /// </summary>		
		private Int16 _check_default;
        public Int16 CHECK_DEFAULT
        {
            get{ return _check_default; }
            set{ _check_default = value; }
        }        
		/// <summary>
		/// CRFģ������id
        /// </summary>		
		private DateTime _version_date;
        public DateTime VERSION_DATE
        {
            get{ return _version_date; }
            set{ _version_date = value; }
        }        
		/// <summary>
		/// CRFl��Դ
        /// </summary>		
		private string _crf_content_id;
        [StringLength(50)]
        public string CRF_CONTENT_ID
        {
            get{ return _crf_content_id; }
            set{ _crf_content_id = value; }
        }        
		/// <summary>
		/// crf�鿴ģ��·��
        /// </summary>		
		private string _crf_from;
        [StringLength(50)]
        public string CRF_FROM
        {
            get{ return _crf_from; }
            set{ _crf_from = value; }
        }        
		/// <summary>
		/// �༭����XMl
        /// </summary>		
		private string _select_templet_path;
        [StringLength(100)]
        public string SELECT_TEMPLET_PATH
        {
            get{ return _select_templet_path; }
            set{ _select_templet_path = value; }
        }
        /// <summary>
        /// �鿴����XMl
        /// </summary>		
   
		private string _editedxmlcontent;
        public string EDITEDXMLCONTENT
        {
            get{ return _editedxmlcontent; }
            set{ _editedxmlcontent = value; }
        }        
		/// <summary>
		/// �ϴθ���ʱ��
        /// </summary>		
		private string _viewxmlcontent;
        public string VIEWXMLCONTENT
        {
            get{ return _viewxmlcontent; }
            set{ _viewxmlcontent = value; }
        }        
		/// <summary>
		/// ���ʹ��ʱ��
        /// </summary>		
		private DateTime _lastupdate_date;
        public DateTime LASTUPDATE_DATE
        {
            get{ return _lastupdate_date; }
            set{ _lastupdate_date = value; }
        }        
		/// <summary>
		/// �ϴ�ʹ���û�ID
        /// </summary>		
		private DateTime _lastuse_date;
        public DateTime LASTUSE_DATE
        {
            get{ return _lastuse_date; }
            set{ _lastuse_date = value; }
        }        
		/// <summary>
		/// �Ƿ���ʾ���Ŀ��ǰ׺ 0�� 1 ��
        /// </summary>		
		private string _lastuse_userid;
        [StringLength(100)]
        public string LASTUSE_USERID
        {
            get{ return _lastuse_userid; }
            set{ _lastuse_userid = value; }
        }        
		/// <summary>
		/// ģ����
        /// </summary>		
		private Int16 _show_prefixon_flag;
        public Int16 SHOW_PREFIXON_FLAG
        {
            get{ return _show_prefixon_flag; }
            set{ _show_prefixon_flag = value; }
        }        
		/// <summary>
		/// �༭����html
        /// </summary>		
		private string _editehtml_contet;
        public string EDITEHTML_CONTET
        {
            get{ return _editehtml_contet; }
            set{ _editehtml_contet = value; }
        }        
		/// <summary>
		/// �鿴����html
        /// </summary>		
		private string _viewhtml_contet;
        public string VIEWHTML_CONTET
        {
            get{ return _viewhtml_contet; }
            set{ _viewhtml_contet = value; }
        }        
		/// <summary>
		/// �༭����appjson
        /// </summary>		
		private string _edite_app_json;
        public string EDITE_APP_JSON
        {
            get{ return _edite_app_json; }
            set{ _edite_app_json = value; }
        }        
		/// <summary>
		/// �鿴����appjson
        /// </summary>		
		private string _view_app_json;
        public string VIEW_APP_JSON
        {
            get{ return _view_app_json; }
            set{ _view_app_json = value; }
        }        
		/// <summary>
		/// �Ƿ���ʾ����Ԫǰ׺��ʾ
        /// </summary>		
		private Int16 _showflag;
        public Int16 SHOWFLAG
        {
            get{ return _showflag; }
            set{ _showflag = value; }
        }        
		/// <summary>
		/// �����js������
        /// </summary>		
		private string _js_fun;
        public string JS_FUN
        {
            get{ return _js_fun; }
            set{ _js_fun = value; }
        }

        /// <summary>
        /// ���ֱ���
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


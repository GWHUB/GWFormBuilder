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
		public class DRR_SYSTEM_USER
	{
   		     
      	/// <summary>
		/// �û��ʺű��
        /// </summary>		
		private string _user_id;
        [StringLength(50)]
        public string USER_ID
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// �û�����
        /// </summary>		
		private string _user_name;
        [StringLength(200)]
        public string USER_NAME
        {
            get{ return _user_name; }
            set{ _user_name = value; }
        }        
		/// <summary>
		/// �û���ʵ����
        /// </summary>		
		private string _real_name;
        [StringLength(200)]
        public string REAL_NAME
        {
            get{ return _real_name; }
            set{ _real_name = value; }
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
		/// �Ա�
        /// </summary>		
		private string _sex;
        [StringLength(50)]
        public string SEX
        {
            get{ return _sex; }
            set{ _sex = value; }
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
		/// ��ϵ��ʽ
        /// </summary>		
		private string _contact_way;
        [StringLength(1000)]
        public string CONTACT_WAY
        {
            get{ return _contact_way; }
            set{ _contact_way = value; }
        }        
		/// <summary>
		/// ������
        /// </summary>		
		private Int16 _order_flag;
        public Int16 ORDER_FLAG
        {
            get{ return _order_flag; }
            set{ _order_flag = value; }
        }        
		/// <summary>
		/// ���ñ��
        /// </summary>		
		private Int16 _use_flag;
        public Int16 USE_FLAG
        {
            get{ return _use_flag; }
            set{ _use_flag = value; }
        }        
		/// <summary>
		/// �����˻����
        /// </summary>		
		private Int16 _internal_flag;
        public Int16 INTERNAL_FLAG
        {
            get{ return _internal_flag; }
            set{ _internal_flag = value; }
        }        
		/// <summary>
		/// ��Ƭ·��
        /// </summary>		
		private string _photo_path;
        [StringLength(500)]
        public string PHOTO_PATH
        {
            get{ return _photo_path; }
            set{ _photo_path = value; }
        }        
		/// <summary>
		/// סַ
        /// </summary>		
		private string _address;
        [StringLength(1000)]
        public string ADDRESS
        {
            get{ return _address; }
            set{ _address = value; }
        }        
		/// <summary>
		/// ְ��
        /// </summary>		
		private string _position;
        [StringLength(1000)]
        public string POSITION
        {
            get{ return _position; }
            set{ _position = value; }
        }        
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
		/// ���˼��
        /// </summary>		
		private string _intro;
        [StringLength(500)]
        public string INTRO
        {
            get{ return _intro; }
            set{ _intro = value; }
        }        
		/// <summary>
		/// ���
        /// </summary>		
		private Int16 _id;
        public Int16 ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// 0�����ã�1ɾ����2����.
        /// </summary>		
		private string _status;
        [StringLength(20)]
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// PASSWORD
        /// </summary>		
		private string _password;
        [StringLength(100)]
        public string PASSWORD
        {
            get{ return _password; }
            set{ _password = value; }
        }        
		/// <summary>
		/// ����ʱ��
        /// </summary>		
		private DateTime _create_date;
        public DateTime CREATE_DATE
        {
            get{ return _create_date; }
            set{ _create_date = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private string _email;
        [StringLength(200)]
        public string EMAIL
        {
            get{ return _email; }
            set{ _email = value; }
        }        
		   
	}
}


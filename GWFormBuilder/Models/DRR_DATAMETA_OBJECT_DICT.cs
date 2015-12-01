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
		public class DRR_DATAMETA_OBJECT_DICT
	{
   		     
      	/// <summary>
		/// �����ʾ
        /// </summary>		
		private string _object_identity;
        [StringLength(100)]
        public string OBJECT_IDENTITY
        {
            get{ return _object_identity; }
            set{ _object_identity = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private string _object_name;
        [StringLength(200)]
        public string OBJECT_NAME
        {
            get{ return _object_name; }
            set{ _object_name = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private string _object_describe;
        [StringLength(300)]
        public string OBJECT_DESCRIBE
        {
            get{ return _object_describe; }
            set{ _object_describe = value; }
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
		/// ����ʱ��
        /// </summary>		
		private DateTime _create_date;
        public DateTime CREATE_DATE
        {
            get{ return _create_date; }
            set{ _create_date = value; }
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
		/// ״̬ 0���� ��1��ˣ�2�ϲ���3ɾ��
        /// </summary>		
		private string _status;
        [StringLength(20)]
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// �ϴθ���ʱ��
        /// </summary>		
		private DateTime _lastupdate_date;
        public DateTime LASTUPDATE_DATE
        {
            get{ return _lastupdate_date; }
            set{ _lastupdate_date = value; }
        }        
		/// <summary>
		/// ���ʹ��ʱ��
        /// </summary>		
		private DateTime _lastuse_date;
        public DateTime LASTUSE_DATE
        {
            get{ return _lastuse_date; }
            set{ _lastuse_date = value; }
        }        
		/// <summary>
		/// �ϴ�ʹ���û�ID
        /// </summary>		
		private string _lastuse_userid;
        [StringLength(60)]
        public string LASTUSE_USERID
        {
            get{ return _lastuse_userid; }
            set{ _lastuse_userid = value; }
        }        
		/// <summary>
		/// �汾��
        /// </summary>		
		private string _version;
        [StringLength(100)]
        public string VERSION
        {
            get{ return _version; }
            set{ _version = value; }
        }        
		/// <summary>
		/// �汾����
        /// </summary>		
		private DateTime _version_date;
        public DateTime VERSION_DATE
        {
            get{ return _version_date; }
            set{ _version_date = value; }
        }        
		   
	}
}


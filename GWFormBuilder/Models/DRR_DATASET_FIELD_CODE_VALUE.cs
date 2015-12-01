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
	 	//���ݼ���ֵ������ֵ
		public class DRR_DATASET_FIELD_CODE_VALUE
	{
   		     
      	/// <summary>
		/// ��Ŀ����
        /// </summary>		
		private string _project_id;
        [StringLength(50)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// ���ֱ���
        /// </summary>		
		private string _disease_id;
        [StringLength(50)]
        public string DISEASE_ID
        {
            get{ return _disease_id; }
            set{ _disease_id = value; }
        }        
		/// <summary>
		/// ����Ԫ�ڲ���ʶ��
        /// </summary>		
		private string _metadata_inner_identify;
        [StringLength(100)]
        public string METADATA_INNER_IDENTIFY
        {
            get{ return _metadata_inner_identify; }
            set{ _metadata_inner_identify = value; }
        }        
		/// <summary>
		/// ֵ�����
        /// </summary>		
		private string _fieldcode_tablecode;
        [StringLength(100)]
        public string FIELDCODE_TABLECODE
        {
            get{ return _fieldcode_tablecode; }
            set{ _fieldcode_tablecode = value; }
        }        
		/// <summary>
		/// ����ֵ
        /// </summary>		
		private string _fieldcode_value;
        [StringLength(100)]
        public string FIELDCODE_VALUE
        {
            get{ return _fieldcode_value; }
            set{ _fieldcode_value = value; }
        }        
		/// <summary>
		/// ֵ����
        /// </summary>		
		private string _fieldcode_value_cn_name;
        [StringLength(300)]
        public string FIELDCODE_VALUE_CN_NAME
        {
            get{ return _fieldcode_value_cn_name; }
            set{ _fieldcode_value_cn_name = value; }
        }        
		/// <summary>
		/// ֵ����Ӣ����
        /// </summary>		
		private string _fieldcode_value_eg_name;
        [StringLength(200)]
        public string FIELDCODE_VALUE_EG_NAME
        {
            get{ return _fieldcode_value_eg_name; }
            set{ _fieldcode_value_eg_name = value; }
        }        
		/// <summary>
		/// ֵ����
        /// </summary>		
		private string _fieldcode_value_describe;
        [StringLength(300)]
        public string FIELDCODE_VALUE_DESCRIBE
        {
            get{ return _fieldcode_value_describe; }
            set{ _fieldcode_value_describe = value; }
        }        
		/// <summary>
		/// ����ֵ
        /// </summary>		
		private string _field_compute;
        [StringLength(50)]
        public string FIELD_COMPUTE
        {
            get{ return _field_compute; }
            set{ _field_compute = value; }
        }        
		/// <summary>
		/// ƴ����
        /// </summary>		
		private string _input_code;
        [StringLength(50)]
        public string INPUT_CODE
        {
            get{ return _input_code; }
            set{ _input_code = value; }
        }        
		/// <summary>
		/// ����ֵ��Դ
        /// </summary>		
		private string _field_from;
        [StringLength(100)]
        public string FIELD_FROM
        {
            get{ return _field_from; }
            set{ _field_from = value; }
        }        
		/// <summary>
		/// ״̬
        /// </summary>		
		private string _status;
        [StringLength(50)]
        public string STATUS
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// ɾ�����
        /// </summary>		
		private string _del_flag;
        [StringLength(20)]
        public string DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// ���׼��Ӧ����
        /// </summary>		
		private string _field_nameid;
        [StringLength(50)]
        public string FIELD_NAMEID
        {
            get{ return _field_nameid; }
            set{ _field_nameid = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private string _fieldorder;
        [StringLength(50)]
        public string FIELDORDER
        {
            get{ return _fieldorder; }
            set{ _fieldorder = value; }
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


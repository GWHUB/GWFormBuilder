using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
namespace GWFormBuilder.ModelModels
{
    //����Ԫ����
		public class DRR_DATAMETA_GROUP
	{
   		     
      	/// <summary>
		/// ���id
        /// </summary>		
		private Int16 _group_id;
        public Int16 GROUP_ID
        {
            get{ return _group_id; }
            set{ _group_id = value; }
        }        
		/// <summary>
		/// �������
        /// </summary>		
		private string _group_name;
        [StringLength(200)]
        public string GROUP_NAME
        {
            get{ return _group_name; }
            set{ _group_name = value; }
        }        
		/// <summary>
		/// ������id
        /// </summary>		
		private string _create_manid;
        [StringLength(50)]
        public string CREATE_MANID
        {
            get{ return _create_manid; }
            set{ _create_manid = value; }
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
		/// ��Ŀid
        /// </summary>		
		private string _project_id;
        [StringLength(100)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// ����Դ
        /// </summary>		
		private string _group_from;
        [StringLength(100)]
        public string GROUP_FROM
        {
            get{ return _group_from; }
            set{ _group_from = value; }
        }        
		/// <summary>
		/// ���
        /// </summary>		
		private string _group_prefixname;
        [StringLength(300)]
        public string GROUP_PREFIXNAME
        {
            get{ return _group_prefixname; }
            set{ _group_prefixname = value; }
        }        
		/// <summary>
		/// ɾ����� 0δɾ����1��ɾ��
        /// </summary>		
		private string _del_flag;
        [StringLength(20)]
        public string DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		/// <summary>
		/// ��ע
        /// </summary>		
		private string _group_element;
        [StringLength(500)]
        public string GROUP_ELEMENT
        {
            get{ return _group_element; }
            set{ _group_element = value; }
        }        
		/// <summary>
		/// ƴ��
        /// </summary>		
		private string _input_code;
        [StringLength(100)]
        public string INPUT_CODE
        {
            get{ return _input_code; }
            set{ _input_code = value; }
        }        
		/// <summary>
		/// ������
        /// </summary>		
		private string _group_info;
        [StringLength(300)]
        public string GROUP_INFO
        {
            get{ return _group_info; }
            set{ _group_info = value; }
        }        
		   
	}
}


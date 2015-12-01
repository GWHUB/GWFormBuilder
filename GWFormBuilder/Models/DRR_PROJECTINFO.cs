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
		public class DRR_PROJECTINFO
	{
   		     
      	/// <summary>
		/// ��Ŀ�������
        /// </summary>		
		private string  _project_id;
        [StringLength(50)]
        public string  PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }
        /// <summary>
        /// ��Ŀ���������
        /// </summary>		
        private string _project_name;
        [StringLength(300)]
        public string PROJECT_NAME
        {
            get{ return _project_name; }
            set{ _project_name = value; }
        }        
		/// <summary>
		/// ����ʱ��
        /// </summary>		
		private DateTime _create_time;
        public DateTime CREATE_TIME
        {
            get{ return _create_time; }
            set{ _create_time = value; }
        }        
		/// <summary>
		/// ������id
        /// </summary>		
		private string _create_pepoleid;
        [StringLength(100)]
        public string CREATE_PEPOLEID
        {
            get{ return _create_pepoleid; }
            set{ _create_pepoleid = value; }
        }        
		/// <summary>
		/// ����Աid
        /// </summary>		
		private string _disease_manager;
        [StringLength(100)]
        public string DISEASE_MANAGER
        {
            get{ return _disease_manager; }
            set{ _disease_manager = value; }
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
		/// ʱ���
        /// </summary>		
		private DateTime _timestamp;
        public DateTime TIMESTAMP
        {
            get{ return _timestamp; }
            set{ _timestamp = value; }
        }        
		/// <summary>
		/// ����ҽԺid
        /// </summary>		
		private string _hospital_id;
        [StringLength(100)]
        public string HOSPITAL_ID
        {
            get{ return _hospital_id; }
            set{ _hospital_id = value; }
        }        
		/// <summary>
		/// ҽԺ����
        /// </summary>		
		private string _hospital_name;
        [StringLength(500)]
        public string HOSPITAL_NAME
        {
            get{ return _hospital_name; }
            set{ _hospital_name = value; }
        }        
		   
	}
}


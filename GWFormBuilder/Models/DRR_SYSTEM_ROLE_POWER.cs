using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
namespace GWFormBuilder.Model{
		public class DRR_SYSTEM_ROLE_POWER
	{
   		     
      	/// <summary>
		/// ��ɫ���
        /// </summary>		
		private string _role_id;
        [StringLength(50)]
        public string ROLE_ID
        {
            get{ return _role_id; }
            set{ _role_id = value; }
        }        
		/// <summary>
		/// Ȩ�ޱ��
        /// </summary>		
		private string _power_id;
        [StringLength(50)]
        public string POWER_ID
        {
            get{ return _power_id; }
            set{ _power_id = value; }
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
		/// ɾ�����
        /// </summary>		
		private Int16 _del_flag;
        public Int16 DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		   
	}
}


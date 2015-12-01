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
		public class DRR_SYSTEM_USER_ROLE
	{
   		     
      	/// <summary>
		/// 用户编号
        /// </summary>		
		private string _user_id;
        [StringLength(50)]
        public string USER_ID
        {
            get{ return _user_id; }
            set{ _user_id = value; }
        }        
		/// <summary>
		/// 角色编号
        /// </summary>		
		private string _role_id;
        [StringLength(50)]
        public string ROLE_ID
        {
            get{ return _role_id; }
            set{ _role_id = value; }
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
		/// 删除标记
        /// </summary>		
		private Int16 _del_flag;
        public Int16 DEL_FLAG
        {
            get{ return _del_flag; }
            set{ _del_flag = value; }
        }        
		   
	}
}


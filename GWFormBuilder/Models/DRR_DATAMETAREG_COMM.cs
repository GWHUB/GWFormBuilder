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
	 	//����������ʽ 
		public class DRR_DATAMETAREG_COMM
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>		
		private string _reg_id;
        [StringLength(100)]
        public string REG_ID
        {
            get{ return _reg_id; }
            set{ _reg_id = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private string _reg_name;
        [StringLength(100)]
        public string REG_NAME
        {
            get{ return _reg_name; }
            set{ _reg_name = value; }
        }        
		/// <summary>
		/// ������ʽ
        /// </summary>		
		private string _reg_text;
        [StringLength(300)]
        public string REG_TEXT
        {
            get{ return _reg_text; }
            set{ _reg_text = value; }
        }        
		/// <summary>
		/// ��ע
        /// </summary>		
		private string _info;
        [StringLength(300)]
        public string INFO
        {
            get{ return _info; }
            set{ _info = value; }
        }        
		   
	}
}


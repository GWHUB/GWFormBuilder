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
		public class DRR_DIAGNOSIS_DICT
	{
   		     
      	/// <summary>
		/// ��ϱ���
        /// </summary>		
		private string _diagnosis_code;
        [StringLength(100)]
        public string DIAGNOSIS_CODE
        {
            get{ return _diagnosis_code; }
            set{ _diagnosis_code = value; }
        }        
		/// <summary>
		/// �������
        /// </summary>		
		private string _diagnosis_name;
        [StringLength(500)]
        public string DIAGNOSIS_NAME
        {
            get{ return _diagnosis_name; }
            set{ _diagnosis_name = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private string _parent_code;
        [StringLength(100)]
        public string PARENT_CODE
        {
            get{ return _parent_code; }
            set{ _parent_code = value; }
        }        
		/// <summary>
		/// ��ϼ���
        /// </summary>		
		private Int16 _diagnosis_level;
        public Int16 DIAGNOSIS_LEVEL
        {
            get{ return _diagnosis_level; }
            set{ _diagnosis_level = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private Int16 _diagnosis_order;
        public Int16 DIAGNOSIS_ORDER
        {
            get{ return _diagnosis_order; }
            set{ _diagnosis_order = value; }
        }        
		/// <summary>
		/// ������
        /// </summary>		
		private string _object_class;
        [StringLength(500)]
        public string OBJECT_CLASS
        {
            get{ return _object_class; }
            set{ _object_class = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private string _features_class;
        [StringLength(500)]
        public string FEATURES_CLASS
        {
            get{ return _features_class; }
            set{ _features_class = value; }
        }        
		/// <summary>
		/// ��ʾ
        /// </summary>		
		private string _show_class;
        [StringLength(500)]
        public string SHOW_CLASS
        {
            get{ return _show_class; }
            set{ _show_class = value; }
        }        
		/// <summary>
		/// ����Ԫ��ʶ��
        /// </summary>		
		private string _metadata_identify;
        [StringLength(100)]
        public string METADATA_IDENTIFY
        {
            get{ return _metadata_identify; }
            set{ _metadata_identify = value; }
        }        
		/// <summary>
		/// ����Ԫ����
        /// </summary>		
		private string _metadata_name;
        [StringLength(500)]
        public string METADATA_NAME
        {
            get{ return _metadata_name; }
            set{ _metadata_name = value; }
        }        
		   
	}
}


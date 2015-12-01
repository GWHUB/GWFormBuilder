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
	 	//����Ԫֵ���Ӧ��������Ԫ
		public class DRR_DATAMETAFIELDCHIRLD
	{
   		     
      	/// <summary>
		/// ����
        /// </summary>		
		private string _id;
        [StringLength(50)]
        public string ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private string _parentid;
        [StringLength(50)]
        public string PARENTID
        {
            get{ return _parentid; }
            set{ _parentid = value; }
        }        
		/// <summary>
		/// ������Ԫ����
        /// </summary>		
		private string _datametaidentity;
        [StringLength(50)]
        public string DATAMETAIDENTITY
        {
            get{ return _datametaidentity; }
            set{ _datametaidentity = value; }
        }        
		/// <summary>
		/// ֵ��valueֵ
        /// </summary>		
		private string _fieldcode;
        [StringLength(100)]
        public string FIELDCODE
        {
            get{ return _fieldcode; }
            set{ _fieldcode = value; }
        }        
		/// <summary>
		/// ֵ������
        /// </summary>		
		private string _fieldname;
        [StringLength(300)]
        public string FIELDNAME
        {
            get{ return _fieldname; }
            set{ _fieldname = value; }
        }        
		/// <summary>
		/// ������Ԫ����
        /// </summary>		
		private string _chirldidentity;
        [StringLength(100)]
        public string CHIRLDIDENTITY
        {
            get{ return _chirldidentity; }
            set{ _chirldidentity = value; }
        }        
		/// <summary>
		/// ��Ŀ����
        /// </summary>		
		private string _project_id;
        [StringLength(100)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
        }        
		/// <summary>
		/// ���ݼ�����
        /// </summary>		
		private string _datasetid;
        [StringLength(50)]
        public string DATASETID
        {
            get{ return _datasetid; }
            set{ _datasetid = value; }
        }        
		/// <summary>
		/// ������
        /// </summary>		
		private Int16 _orderindex;
        public Int16 ORDERINDEX
        {
            get{ return _orderindex; }
            set{ _orderindex = value; }
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
		/// ִ�з�����0����,1���أ�
        /// </summary>		
		private string _domethd;
        [StringLength(100)]
        public string DOMETHD
        {
            get{ return _domethd; }
            set{ _domethd = value; }
        }        
		/// <summary>
		/// �Ƿ������ݼ���ʾ0�� 1��
        /// </summary>		
		private Int16 _is_dataset;
        public Int16 IS_DATASET
        {
            get{ return _is_dataset; }
            set{ _is_dataset = value; }
        }        
		/// <summary>
		/// ���Ŀ
        /// </summary>		
		private string _metaitem;
        [StringLength(300)]
        public string METAITEM
        {
            get{ return _metaitem; }
            set{ _metaitem = value; }
        }        
		/// <summary>
		/// ��������text��checkbox
        /// </summary>		
		private string _input_type;
        [StringLength(100)]
        public string INPUT_TYPE
        {
            get{ return _input_type; }
            set{ _input_type = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private string _data_meta_datatype;
        [StringLength(100)]
        public string DATA_META_DATATYPE
        {
            get{ return _data_meta_datatype; }
            set{ _data_meta_datatype = value; }
        }        
		   
	}
}


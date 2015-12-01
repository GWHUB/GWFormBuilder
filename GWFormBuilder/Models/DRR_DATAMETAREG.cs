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
	 	//����Ԫ������ʽ��
		public class DRR_DATAMETAREG
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>		
		private string _reg_id;
        [StringLength(50)]
        public string REG_ID
        {
            get{ return _reg_id; }
            set{ _reg_id = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private string _reg_name;
        [StringLength(200)]
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
		/// <summary>
		/// ����ԪId
        /// </summary>		
		private string _datameta_id;
        [StringLength(100)]
        public string DATAMETA_ID
        {
            get{ return _datameta_id; }
            set{ _datameta_id = value; }
        }        
		/// <summary>
		/// ���ֵ
        /// </summary>		
		private Int16 _max;
        public Int16 MAX
        {
            get{ return _max; }
            set{ _max = value; }
        }        
		/// <summary>
		/// ��Сֵ
        /// </summary>		
		private Int16 _min;
        public Int16 MIN
        {
            get{ return _min; }
            set{ _min = value; }
        }        
		/// <summary>
		/// ��������
        /// </summary>		
		private string _datatype;
        [StringLength(100)]
        public string DATATYPE
        {
            get{ return _datatype; }
            set{ _datatype = value; }
        }        
		/// <summary>
		/// ����
        /// </summary>		
		private string _precision;
        [StringLength(100)]
        public string PRECISION
        {
            get{ return _precision; }
            set{ _precision = value; }
        }        
		/// <summary>
		/// �����ʾ 0,���1��ѡ�2���̳и�����Ԫ����������Ԫ���ѡ������
        /// </summary>		
		private string _mast_flag;
        [StringLength(20)]
        public string MAST_FLAG
        {
            get{ return _mast_flag; }
            set{ _mast_flag = value; }
        }        
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
		/// ��󳤶�
        /// </summary>		
		private Int16 _maxlength;
        public Int16 MAXLENGTH
        {
            get{ return _maxlength; }
            set{ _maxlength = value; }
        }        
		/// <summary>
		/// ��С����
        /// </summary>		
		private Int16 _minlength;
        public Int16 MINLENGTH
        {
            get{ return _minlength; }
            set{ _minlength = value; }
        }        
		/// <summary>
		/// ����λ��
        /// </summary>		
		private Int16 _int_num;
        public Int16 INT_NUM
        {
            get{ return _int_num; }
            set{ _int_num = value; }
        }        
		/// <summary>
		/// С��λ��
        /// </summary>		
		private Int16 _Int16_num;
        public Int16 Int16_NUM
        {
            get{ return _Int16_num; }
            set{ _Int16_num = value; }
        }        
		/// <summary>
		/// ����Ԫ�ڲ���ʶ��
        /// </summary>		
		private string _datameta_innerid;
        [StringLength(50)]
        public string DATAMETA_INNERID
        {
            get{ return _datameta_innerid; }
            set{ _datameta_innerid = value; }
        }        
		/// <summary>
		/// ���ݼ�����
        /// </summary>		
		private string _dataset_id;
        [StringLength(50)]
        public string DATASET_ID
        {
            get{ return _dataset_id; }
            set{ _dataset_id = value; }
        }        
		   
	}
}


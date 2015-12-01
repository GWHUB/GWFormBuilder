using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
namespace GWFormBuilder.Models
{
		public class DRR_DATAMETA_GROUP_VS_DATAMETA
	{
   		     
      	/// <summary>
		/// ���id?
        /// </summary>		
		private string _group_id;
        [StringLength(300)]
        public string GROUP_ID
        {
            get{ return _group_id; }
            set{ _group_id = value; }
        }        
		/// <summary>
		/// ����Ԫ��ʾ��
        /// </summary>		
		private string _datameta_identity;
        [StringLength(300)]
        public string DATAMETA_IDENTITY
        {
            get{ return _datameta_identity; }
            set{ _datameta_identity = value; }
        }        
		/// <summary>
		/// ����Ԫ����
        /// </summary>		
		private string _datameta_name;
        [StringLength(300)]
        public string DATAMETA_NAME
        {
            get{ return _datameta_name; }
            set{ _datameta_name = value; }
        }        
		/// <summary>
		/// ������Ŀ
        /// </summary>		
		private string _project_id;
        [StringLength(300)]
        public string PROJECT_ID
        {
            get{ return _project_id; }
            set{ _project_id = value; }
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
		/// ��������Ԫ��ʾ��
        /// </summary>		
		private string _father_datametaidentity;
        [StringLength(100)]
        public string FATHER_DATAMETAIDENTITY
        {
            get{ return _father_datametaidentity; }
            set{ _father_datametaidentity = value; }
        }        
		/// <summary>
		/// ����Ԫ��������ĺ������������أ�0 ��ʾ ,2 ���� 6��7 ��
        /// </summary>		
		private string _datameta_action;
        [StringLength(300)]
        public string DATAMETA_ACTION
        {
            get{ return _datameta_action; }
            set{ _datameta_action = value; }
        }        
		/// <summary>
		/// ����Ƕ�׹�ϵ c�ڸ�����Ԫ���棬����ʱ���ڸ�ֵʱ��ʾ
        /// </summary>		
		private string _father_relation;
        [StringLength(100)]
        public string FATHER_RELATION
        {
            get{ return _father_relation; }
            set{ _father_relation = value; }
        }        
		/// <summary>
		/// ���������ַ���
        /// </summary>		
		private string _father_connstr;
        [StringLength(300)]
        public string FATHER_CONNSTR
        {
            get{ return _father_connstr; }
            set{ _father_connstr = value; }
        }        
		/// <summary>
		/// ����Ԫ�ڲ���ʾ��
        /// </summary>		
		private string _metadata_inner_identify;
        [StringLength(100)]
        public string METADATA_INNER_IDENTIFY
        {
            get{ return _metadata_inner_identify; }
            set{ _metadata_inner_identify = value; }
        }        
		/// <summary>
		/// �Ƿ���������Ԫ 0�ǣ� 1 ��
        /// </summary>		
		private string _is_father;
        [StringLength(20)]
        public string IS_FATHER
        {
            get{ return _is_father; }
            set{ _is_father = value; }
        }        
		/// <summary>
		/// �Ƿ��Ǽ�������Ԫ0����1��
        /// </summary>		
		private string _is_compute;
        [StringLength(20)]
        public string IS_COMPUTE
        {
            get{ return _is_compute; }
            set{ _is_compute = value; }
        }        
		/// <summary>
		/// ��ʾ˳��
        /// </summary>		
		private Int16 _shor_order;
        public Int16 SHOR_ORDER
        {
            get{ return _shor_order; }
            set{ _shor_order = value; }
        }        
		   
	}
}


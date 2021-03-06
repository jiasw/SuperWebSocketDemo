﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Model
{

	/// <summary>
	/// 实体类zkpt_mm_fileManage 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("zkpt_mm_fileManage")]
	[Serializable]
	public partial class zkpt_mm_fileManage : Entity 
	{
		#region Model
		private long _fId;
		private string _tmark;
		private string _fDisplayName;
		private string _fNodeId;
		private string _fNodePath;
		private string _fbdlj;
		private string _fbdmc;
		private int _fType;
		private string _fFileSize;
		private DateTime _fAddTime;
		private DateTime _fLastUpDate;
		private string _fAttribute;
		private int _fdownupType;
		private bool _fwc;
		/// <summary>
		/// 
		/// </summary>
		public long fId
		{
			get{ return _fId; }
			set
			{
				this.OnPropertyValueChange(_.fId,_fId,value);
				this._fId=value;
			}
		}
		/// <summary>
		/// 木马标识符
		/// </summary>
		public string tmark
		{
			get{ return _tmark; }
			set
			{
				this.OnPropertyValueChange(_.tmark,_tmark,value);
				this._tmark=value;
			}
		}
		/// <summary>
		/// 文件显示名称
		/// </summary>
		public string fDisplayName
		{
			get{ return _fDisplayName; }
			set
			{
				this.OnPropertyValueChange(_.fDisplayName,_fDisplayName,value);
				this._fDisplayName=value;
			}
		}
		/// <summary>
		/// 文件当前路径
		/// </summary>
		public string fNodeId
		{
			get{ return _fNodeId; }
			set
			{
				this.OnPropertyValueChange(_.fNodeId,_fNodeId,value);
				this._fNodeId=value;
			}
		}
		/// <summary>
		/// 文件父路径
		/// </summary>
		public string fNodePath
		{
			get{ return _fNodePath; }
			set
			{
				this.OnPropertyValueChange(_.fNodePath,_fNodePath,value);
				this._fNodePath=value;
			}
		}
		/// <summary>
		/// 文件所在本地路径
		/// </summary>
		public string fbdlj
		{
			get{ return _fbdlj; }
			set
			{
				this.OnPropertyValueChange(_.fbdlj,_fbdlj,value);
				this._fbdlj=value;
			}
		}
		/// <summary>
		/// 文件本地名称
		/// </summary>
		public string fbdmc
		{
			get{ return _fbdmc; }
			set
			{
				this.OnPropertyValueChange(_.fbdmc,_fbdmc,value);
				this._fbdmc=value;
			}
		}
		/// <summary>
		/// 文件类型：0、我的电脑。1.移动硬盘。2.cd。3.硬盘。4.ram。5.net。6.未知。7.文件夹。8.exe。9.dll.10.txt。11.office.12.rar,zip。13.未知.
		/// </summary>
		public int fType
		{
			get{ return _fType; }
			set
			{
				this.OnPropertyValueChange(_.fType,_fType,value);
				this._fType=value;
			}
		}
		/// <summary>
		/// 文件大小
		/// </summary>
		public string fFileSize
		{
			get{ return _fFileSize; }
			set
			{
				this.OnPropertyValueChange(_.fFileSize,_fFileSize,value);
				this._fFileSize=value;
			}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime fAddTime
		{
			get{ return _fAddTime; }
			set
			{
				this.OnPropertyValueChange(_.fAddTime,_fAddTime,value);
				this._fAddTime=value;
			}
		}
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime fLastUpDate
		{
			get{ return _fLastUpDate; }
			set
			{
				this.OnPropertyValueChange(_.fLastUpDate,_fLastUpDate,value);
				this._fLastUpDate=value;
			}
		}
		/// <summary>
		/// 属性
		/// </summary>
		public string fAttribute
		{
			get{ return _fAttribute; }
			set
			{
				this.OnPropertyValueChange(_.fAttribute,_fAttribute,value);
				this._fAttribute=value;
			}
		}
		/// <summary>
		/// _0 代表无状态（初始化文件状态的默认值）  |    1代表下载    2  代表上传   【3下载完成  4  上传完成】 暂不使用
		/// </summary>
		public int fdownupType
		{
			get{ return _fdownupType; }
			set
			{
				this.OnPropertyValueChange(_.fdownupType,_fdownupType,value);
				this._fdownupType=value;
			}
		}
		/// <summary>
		/// 是否完成上传（或者下载）
		/// </summary>
		public bool fwc
		{
			get{ return _fwc; }
			set
			{
				this.OnPropertyValueChange(_.fwc,_fwc,value);
				this._fwc=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.fId;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.fId};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.fId,
				_.tmark,
				_.fDisplayName,
				_.fNodeId,
				_.fNodePath,
				_.fbdlj,
				_.fbdmc,
				_.fType,
				_.fFileSize,
				_.fAddTime,
				_.fLastUpDate,
				_.fAttribute,
				_.fdownupType,
				_.fwc};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._fId,
				this._tmark,
				this._fDisplayName,
				this._fNodeId,
				this._fNodePath,
				this._fbdlj,
				this._fbdmc,
				this._fType,
				this._fFileSize,
				this._fAddTime,
				this._fLastUpDate,
				this._fAttribute,
				this._fdownupType,
				this._fwc};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","zkpt_mm_fileManage");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field fId = new Field("fId","zkpt_mm_fileManage","fId");
			/// <summary>
			/// 木马标识符
			/// </summary>
			public readonly static Field tmark = new Field("tmark","zkpt_mm_fileManage","木马标识符");
			/// <summary>
			/// 文件显示名称
			/// </summary>
			public readonly static Field fDisplayName = new Field("fDisplayName","zkpt_mm_fileManage","文件显示名称");
			/// <summary>
			/// 文件当前路径
			/// </summary>
			public readonly static Field fNodeId = new Field("fNodeId","zkpt_mm_fileManage","文件当前路径");
			/// <summary>
			/// 文件父路径
			/// </summary>
			public readonly static Field fNodePath = new Field("fNodePath","zkpt_mm_fileManage","文件父路径");
			/// <summary>
			/// 文件所在本地路径
			/// </summary>
			public readonly static Field fbdlj = new Field("fbdlj","zkpt_mm_fileManage","文件所在本地路径");
			/// <summary>
			/// 文件本地名称
			/// </summary>
			public readonly static Field fbdmc = new Field("fbdmc","zkpt_mm_fileManage","文件本地名称");
			/// <summary>
			/// 文件类型：0、我的电脑。1.移动硬盘。2.cd。3.硬盘。4.ram。5.net。6.未知。7.文件夹。8.exe。9.dll.10.txt。11.office.12.rar,zip。13.未知.
			/// </summary>
			public readonly static Field fType = new Field("fType","zkpt_mm_fileManage","文件类型：0、我的电脑。1.移动硬盘。2.cd。3.硬盘。4.ram。5.net。6.未知。7.文件夹。8.exe。9.dll.10.txt。11.office.12.rar,zip。13.未知.");
			/// <summary>
			/// 文件大小
			/// </summary>
			public readonly static Field fFileSize = new Field("fFileSize","zkpt_mm_fileManage","文件大小");
			/// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field fAddTime = new Field("fAddTime","zkpt_mm_fileManage","添加时间");
			/// <summary>
			/// 最后修改时间
			/// </summary>
			public readonly static Field fLastUpDate = new Field("fLastUpDate","zkpt_mm_fileManage","最后修改时间");
			/// <summary>
			/// 属性
			/// </summary>
			public readonly static Field fAttribute = new Field("fAttribute","zkpt_mm_fileManage","属性");
			/// <summary>
			/// _0 代表无状态（初始化文件状态的默认值）  |    1代表下载    2  代表上传   【3下载完成  4  上传完成】 暂不使用
			/// </summary>
			public readonly static Field fdownupType = new Field("fdownupType","zkpt_mm_fileManage","_0 代表无状态（初始化文件状态的默认值）  |    1代表下载    2  代表上传   【3下载完成  4  上传完成】 暂不使用");
			/// <summary>
			/// 是否完成上传（或者下载）
			/// </summary>
			public readonly static Field fwc = new Field("fwc","zkpt_mm_fileManage","是否完成上传（或者下载）");
		}
		#endregion


	}
}


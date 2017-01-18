# UNITY3D-DATA-VIEWER
UNITY3D EDITOR DATA_VIEWER .  ／  UNITY3D 可视化数据编辑器 .

# Version 1

## Video on YouTube
[演示视频/Demo Video](http://https://youtu.be/_uk8XBJPZwA)

## Demo Code

··· cs
namespace SmartDataViewerV1
{
	[ConfigEditor("通用编辑")]
	[Serializable]
	public class FilterOptionConfig : ConfigBase<FilterOption>
	{

	}

	[Serializable]
	public class FilterOption : Model
	{
		[ConfigEditorField(2, true)]
		public FilterModel filter_mode;

		[ConfigEditorField(3, true)]
		public EnumLevel currentLevel;

		[ConfigEditorField(4, true)]
		public EnumStatus currentStatus;


		[ConfigEditorField(5, true, "条件(1-10)")]
		public int extionsion_condition;

		[ConfigEditorField(4, true)]
		public bool Enable;
	}

	public enum EnumStatus
	{
		A,
		B,
		C
	}

	public enum EnumLevel
	{
		VIP1,
		VIP2,
		VIP3
	}

	public enum FilterModel
	{
		DEFAULT,
		STATUS,
		LEVEL
	}

}
···


> 使用如下代码 制作编辑器界面
··· cs

namespace SmartDataViewerV1.Editor
{
	public class OpenFilterOptionConfigEditor : ConfigEditorSchema<FilterOption>
	{
		[MenuItem("SmartDataVierV1/Test/Demo")]
		static public void OpenView()
		{
			OpenFilterOptionConfigEditor w = CreateInstance<OpenFilterOptionConfigEditor>();
			w.ShowUtility();
		}

		public override FilterOption AddValue()
		{
			FilterOption r = base.AddValue();
			r.Enable = true;
			return r;
		}

		public override void Initialize()
		{
			SetConfigType(new FilterOptionConfig());
		}
	}
}

···





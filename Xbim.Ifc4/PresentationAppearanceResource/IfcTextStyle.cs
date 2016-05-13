// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextStyle : IIfcPresentationStyle, IfcPresentationStyleSelect
	{
		IIfcTextStyleForDefinedFont @TextCharacterAppearance { get;  set; }
		IIfcTextStyleTextModel @TextStyle { get;  set; }
		IIfcTextFontSelect @TextFontStyle { get;  set; }
		IfcBoolean? @ModelOrDraughting { get;  set; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcTextStyle", 427)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyle : IfcPresentationStyle, IInstantiableEntity, IIfcTextStyle, IContainsEntityReferences, IEquatable<@IfcTextStyle>
	{
		#region IIfcTextStyle explicit implementation
		IIfcTextStyleForDefinedFont IIfcTextStyle.TextCharacterAppearance { 
			get { return @TextCharacterAppearance; } 
 
 
			set { TextCharacterAppearance = value as IfcTextStyleForDefinedFont;}
		}	
		IIfcTextStyleTextModel IIfcTextStyle.TextStyle { 
			get { return @TextStyle; } 
 
 
			set { TextStyle = value as IfcTextStyleTextModel;}
		}	
		IIfcTextFontSelect IIfcTextStyle.TextFontStyle { 
			get { return @TextFontStyle; } 
 
 
			set { TextFontStyle = value as IfcTextFontSelect;}
		}	
		IfcBoolean? IIfcTextStyle.ModelOrDraughting { 
			get { return @ModelOrDraughting; } 
 
			set { ModelOrDraughting = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyle(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTextStyleForDefinedFont _textCharacterAppearance;
		private IfcTextStyleTextModel _textStyle;
		private IfcTextFontSelect _textFontStyle;
		private IfcBoolean? _modelOrDraughting;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 2)]
		public IfcTextStyleForDefinedFont @TextCharacterAppearance 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textCharacterAppearance;
				((IPersistEntity)this).Activate(false);
				return _textCharacterAppearance;
			} 
			set
			{
				SetValue( v =>  _textCharacterAppearance = v, _textCharacterAppearance, value,  "TextCharacterAppearance", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcTextStyleTextModel @TextStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textStyle;
				((IPersistEntity)this).Activate(false);
				return _textStyle;
			} 
			set
			{
				SetValue( v =>  _textStyle = v, _textStyle, value,  "TextStyle", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcTextFontSelect @TextFontStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textFontStyle;
				((IPersistEntity)this).Activate(false);
				return _textFontStyle;
			} 
			set
			{
				SetValue( v =>  _textFontStyle = v, _textFontStyle, value,  "TextFontStyle", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcBoolean? @ModelOrDraughting 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _modelOrDraughting;
				((IPersistEntity)this).Activate(false);
				return _modelOrDraughting;
			} 
			set
			{
				SetValue( v =>  _modelOrDraughting = v, _modelOrDraughting, value,  "ModelOrDraughting", 5);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_textCharacterAppearance = (IfcTextStyleForDefinedFont)(value.EntityVal);
					return;
				case 2: 
					_textStyle = (IfcTextStyleTextModel)(value.EntityVal);
					return;
				case 3: 
					_textFontStyle = (IfcTextFontSelect)(value.EntityVal);
					return;
				case 4: 
					_modelOrDraughting = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyle other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextStyle
            var root = (@IfcTextStyle)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextStyle left, @IfcTextStyle right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextStyle left, @IfcTextStyle right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcTextStyle left, IfcPresentationStyleSelect right)
		{
			return left == right as @IfcTextStyle;
		}

		public static bool operator !=(@IfcTextStyle left, IfcPresentationStyleSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@TextCharacterAppearance != null)
					yield return @TextCharacterAppearance;
				if (@TextStyle != null)
					yield return @TextStyle;
				if (@TextFontStyle != null)
					yield return @TextFontStyle;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
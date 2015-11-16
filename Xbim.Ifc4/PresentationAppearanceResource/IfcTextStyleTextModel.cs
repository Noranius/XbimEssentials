// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextStyleTextModel
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextStyleTextModel : IIfcPresentationItem
	{
		IIfcSizeSelect @TextIndent { get; }
		IfcTextAlignment? @TextAlign { get; }
		IfcTextDecoration? @TextDecoration { get; }
		IIfcSizeSelect @LetterSpacing { get; }
		IIfcSizeSelect @WordSpacing { get; }
		IfcTextTransformation? @TextTransform { get; }
		IIfcSizeSelect @LineHeight { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IfcTextStyleTextModel", 1105)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleTextModel : IfcPresentationItem, IInstantiableEntity, IIfcTextStyleTextModel, IEqualityComparer<@IfcTextStyleTextModel>, IEquatable<@IfcTextStyleTextModel>
	{
		#region IIfcTextStyleTextModel explicit implementation
		IIfcSizeSelect IIfcTextStyleTextModel.TextIndent { get { return @TextIndent; } }	
		IfcTextAlignment? IIfcTextStyleTextModel.TextAlign { get { return @TextAlign; } }	
		IfcTextDecoration? IIfcTextStyleTextModel.TextDecoration { get { return @TextDecoration; } }	
		IIfcSizeSelect IIfcTextStyleTextModel.LetterSpacing { get { return @LetterSpacing; } }	
		IIfcSizeSelect IIfcTextStyleTextModel.WordSpacing { get { return @WordSpacing; } }	
		IfcTextTransformation? IIfcTextStyleTextModel.TextTransform { get { return @TextTransform; } }	
		IIfcSizeSelect IIfcTextStyleTextModel.LineHeight { get { return @LineHeight; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleTextModel(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSizeSelect _textIndent;
		private IfcTextAlignment? _textAlign;
		private IfcTextDecoration? _textDecoration;
		private IfcSizeSelect _letterSpacing;
		private IfcSizeSelect _wordSpacing;
		private IfcTextTransformation? _textTransform;
		private IfcSizeSelect _lineHeight;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @TextIndent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textIndent;
				((IPersistEntity)this).Activate(false);
				return _textIndent;
			} 
			set
			{
				SetValue( v =>  _textIndent = v, _textIndent, value,  "TextIndent");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTextAlignment? @TextAlign 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textAlign;
				((IPersistEntity)this).Activate(false);
				return _textAlign;
			} 
			set
			{
				SetValue( v =>  _textAlign = v, _textAlign, value,  "TextAlign");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTextDecoration? @TextDecoration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textDecoration;
				((IPersistEntity)this).Activate(false);
				return _textDecoration;
			} 
			set
			{
				SetValue( v =>  _textDecoration = v, _textDecoration, value,  "TextDecoration");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @LetterSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _letterSpacing;
				((IPersistEntity)this).Activate(false);
				return _letterSpacing;
			} 
			set
			{
				SetValue( v =>  _letterSpacing = v, _letterSpacing, value,  "LetterSpacing");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @WordSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wordSpacing;
				((IPersistEntity)this).Activate(false);
				return _wordSpacing;
			} 
			set
			{
				SetValue( v =>  _wordSpacing = v, _wordSpacing, value,  "WordSpacing");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTextTransformation? @TextTransform 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textTransform;
				((IPersistEntity)this).Activate(false);
				return _textTransform;
			} 
			set
			{
				SetValue( v =>  _textTransform = v, _textTransform, value,  "TextTransform");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @LineHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lineHeight;
				((IPersistEntity)this).Activate(false);
				return _lineHeight;
			} 
			set
			{
				SetValue( v =>  _lineHeight = v, _lineHeight, value,  "LineHeight");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_textIndent = (IfcSizeSelect)(value.EntityVal);
					return;
				case 1: 
					_textAlign = value.StringVal;
					return;
				case 2: 
					_textDecoration = value.StringVal;
					return;
				case 3: 
					_letterSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				case 4: 
					_wordSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				case 5: 
					_textTransform = value.StringVal;
					return;
				case 6: 
					_lineHeight = (IfcSizeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyleTextModel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextStyleTextModel
            var root = (@IfcTextStyleTextModel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextStyleTextModel left, @IfcTextStyleTextModel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextStyleTextModel left, @IfcTextStyleTextModel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextStyleTextModel x, @IfcTextStyleTextModel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextStyleTextModel obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
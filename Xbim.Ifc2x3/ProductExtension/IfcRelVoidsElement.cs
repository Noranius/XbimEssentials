// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelVoidsElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelVoidsElement : IIfcRelConnects
	{
		IIfcElement @RelatingBuildingElement { get;  set; }
		IIfcFeatureElementSubtraction @RelatedOpeningElement { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelVoidsElement", 496)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelVoidsElement : IfcRelConnects, IInstantiableEntity, IIfcRelVoidsElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelVoidsElement>
	{
		#region IIfcRelVoidsElement explicit implementation
		IIfcElement IIfcRelVoidsElement.RelatingBuildingElement { 
			get { return @RelatingBuildingElement; } 
 
 
			set { RelatingBuildingElement = value as IfcElement;}
		}	
		IIfcFeatureElementSubtraction IIfcRelVoidsElement.RelatedOpeningElement { 
			get { return @RelatedOpeningElement; } 
 
 
			set { RelatedOpeningElement = value as IfcFeatureElementSubtraction;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelVoidsElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcElement _relatingBuildingElement;
		private IfcFeatureElementSubtraction _relatedOpeningElement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcElement @RelatingBuildingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingBuildingElement;
				((IPersistEntity)this).Activate(false);
				return _relatingBuildingElement;
			} 
			set
			{
				SetValue( v =>  _relatingBuildingElement = v, _relatingBuildingElement, value,  "RelatingBuildingElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 6)]
		public IfcFeatureElementSubtraction @RelatedOpeningElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedOpeningElement;
				((IPersistEntity)this).Activate(false);
				return _relatedOpeningElement;
			} 
			set
			{
				SetValue( v =>  _relatedOpeningElement = v, _relatedOpeningElement, value,  "RelatedOpeningElement", 6);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedOpeningElement = (IfcFeatureElementSubtraction)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelVoidsElement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelVoidsElement
            var root = (@IfcRelVoidsElement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelVoidsElement left, @IfcRelVoidsElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelVoidsElement left, @IfcRelVoidsElement right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@RelatingBuildingElement != null)
					yield return @RelatingBuildingElement;
				if (@RelatedOpeningElement != null)
					yield return @RelatedOpeningElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingBuildingElement != null)
					yield return @RelatingBuildingElement;
				if (@RelatedOpeningElement != null)
					yield return @RelatedOpeningElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
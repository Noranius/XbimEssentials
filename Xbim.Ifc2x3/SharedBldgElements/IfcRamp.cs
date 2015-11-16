// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRamp
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRamp : IIfcBuildingElement
	{
		IfcRampTypeEnum @ShapeType { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IfcRamp", 414)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRamp : IfcBuildingElement, IInstantiableEntity, IIfcRamp, IEqualityComparer<@IfcRamp>, IEquatable<@IfcRamp>
	{
		#region IIfcRamp explicit implementation
		IfcRampTypeEnum IIfcRamp.ShapeType { get { return @ShapeType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRamp(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRampTypeEnum _shapeType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcRampTypeEnum @ShapeType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeType;
				((IPersistEntity)this).Activate(false);
				return _shapeType;
			} 
			set
			{
				SetValue( v =>  _shapeType = v, _shapeType, value,  "ShapeType");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _shapeType = (IfcRampTypeEnum) System.Enum.Parse(typeof (IfcRampTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:            ((HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 1) AND (NOT(EXISTS(SELF\IfcProduct.Representation))));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRamp other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRamp
            var root = (@IfcRamp)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRamp left, @IfcRamp right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRamp left, @IfcRamp right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRamp x, @IfcRamp y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRamp obj)
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
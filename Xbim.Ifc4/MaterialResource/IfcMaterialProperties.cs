// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProperties : IIfcExtendedProperties
	{
		IIfcMaterialDefinition @Material { get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[IndexedClass]
	[ExpressType("IfcMaterialProperties", 765)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProperties : IfcExtendedProperties, IInstantiableEntity, IIfcMaterialProperties, IEqualityComparer<@IfcMaterialProperties>, IEquatable<@IfcMaterialProperties>
	{
		#region IIfcMaterialProperties explicit implementation
		IIfcMaterialDefinition IIfcMaterialProperties.Material { get { return @Material; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialDefinition _material;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterialDefinition @Material 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _material;
				((IPersistEntity)this).Activate(false);
				return _material;
			} 
			set
			{
				SetValue( v =>  _material = v, _material, value,  "Material");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_material = (IfcMaterialDefinition)(value.EntityVal);
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
        public bool Equals(@IfcMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialProperties
            var root = (@IfcMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialProperties left, @IfcMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialProperties left, @IfcMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialProperties x, @IfcMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialProperties obj)
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
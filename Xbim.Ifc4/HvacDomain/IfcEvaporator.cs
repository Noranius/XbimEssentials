// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.SharedBldgServiceElements;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.HvacDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEvaporator
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEvaporator : IIfcEnergyConversionDevice
	{
		IfcEvaporatorTypeEnum? @PredefinedType { get;  set; }
	
	}
}

namespace Xbim.Ifc4.HvacDomain
{
	[ExpressType("IfcEvaporator", 1167)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEvaporator : IfcEnergyConversionDevice, IInstantiableEntity, IIfcEvaporator, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcEvaporator>
	{
		#region IIfcEvaporator explicit implementation
		IfcEvaporatorTypeEnum? IIfcEvaporator.PredefinedType { 
			get { return @PredefinedType; } 
 
			set { PredefinedType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEvaporator(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcEvaporatorTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 35)]
		public IfcEvaporatorTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 9);
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
                    _predefinedType = (IfcEvaporatorTypeEnum) System.Enum.Parse(typeof (IfcEvaporatorTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEvaporator other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEvaporator
            var root = (@IfcEvaporator)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEvaporator left, @IfcEvaporator right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEvaporator left, @IfcEvaporator right)
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
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
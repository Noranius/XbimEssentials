// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedMgmtElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssociatesAppliedValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssociatesAppliedValue : IIfcRelAssociates
	{
		IIfcAppliedValue @RelatingAppliedValue { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[ExpressType("IfcRelAssociatesAppliedValue", 699)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssociatesAppliedValue : IfcRelAssociates, IInstantiableEntity, IIfcRelAssociatesAppliedValue, IEqualityComparer<@IfcRelAssociatesAppliedValue>, IEquatable<@IfcRelAssociatesAppliedValue>
	{
		#region IIfcRelAssociatesAppliedValue explicit implementation
		IIfcAppliedValue IIfcRelAssociatesAppliedValue.RelatingAppliedValue { get { return @RelatingAppliedValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssociatesAppliedValue(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAppliedValue _relatingAppliedValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAppliedValue @RelatingAppliedValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingAppliedValue;
				((IPersistEntity)this).Activate(false);
				return _relatingAppliedValue;
			} 
			set
			{
				SetValue( v =>  _relatingAppliedValue = v, _relatingAppliedValue, value,  "RelatingAppliedValue");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_relatingAppliedValue = (IfcAppliedValue)(value.EntityVal);
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
        public bool Equals(@IfcRelAssociatesAppliedValue other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssociatesAppliedValue
            var root = (@IfcRelAssociatesAppliedValue)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssociatesAppliedValue left, @IfcRelAssociatesAppliedValue right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssociatesAppliedValue left, @IfcRelAssociatesAppliedValue right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssociatesAppliedValue x, @IfcRelAssociatesAppliedValue y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssociatesAppliedValue obj)
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
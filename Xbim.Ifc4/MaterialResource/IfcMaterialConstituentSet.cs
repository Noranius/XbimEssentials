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
using Xbim.Ifc4.MaterialResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialConstituentSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialConstituentSet : IIfcMaterialDefinition
	{
		IfcLabel? @Name { get; }
		IfcText? @Description { get; }
		IEnumerable<IIfcMaterialConstituent> @MaterialConstituents { get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialConstituentSet", 752)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialConstituentSet : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterialConstituentSet, IEqualityComparer<@IfcMaterialConstituentSet>, IEquatable<@IfcMaterialConstituentSet>
	{
		#region IIfcMaterialConstituentSet explicit implementation
		IfcLabel? IIfcMaterialConstituentSet.Name { get { return @Name; } }	
		IfcText? IIfcMaterialConstituentSet.Description { get { return @Description; } }	
		IEnumerable<IIfcMaterialConstituent> IIfcMaterialConstituentSet.MaterialConstituents { get { return @MaterialConstituents; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialConstituentSet(IModel model) : base(model) 		{ 
			Model = model; 
			_materialConstituents = new OptionalItemSet<IfcMaterialConstituent>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private OptionalItemSet<IfcMaterialConstituent> _materialConstituents;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcMaterialConstituent> @MaterialConstituents 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _materialConstituents;
				((IPersistEntity)this).Activate(false);
				return _materialConstituents;
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					if (_materialConstituents == null) _materialConstituents = new OptionalItemSet<IfcMaterialConstituent>( this );
					_materialConstituents.InternalAdd((IfcMaterialConstituent)value.EntityVal);
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
        public bool Equals(@IfcMaterialConstituentSet other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialConstituentSet
            var root = (@IfcMaterialConstituentSet)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialConstituentSet left, @IfcMaterialConstituentSet right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialConstituentSet left, @IfcMaterialConstituentSet right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialConstituentSet x, @IfcMaterialConstituentSet y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialConstituentSet obj)
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
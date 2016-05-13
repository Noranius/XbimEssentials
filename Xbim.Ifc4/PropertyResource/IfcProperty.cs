// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.ConstraintResource;
using Xbim.Ifc4.ApprovalResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProperty
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProperty : IIfcPropertyAbstraction
	{
		IfcIdentifier @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IEnumerable<IIfcPropertySet> @PartOfPset {  get; }
		IEnumerable<IIfcPropertyDependencyRelationship> @PropertyForDependance {  get; }
		IEnumerable<IIfcPropertyDependencyRelationship> @PropertyDependsOn {  get; }
		IEnumerable<IIfcComplexProperty> @PartOfComplex {  get; }
		IEnumerable<IIfcResourceConstraintRelationship> @HasConstraints {  get; }
		IEnumerable<IIfcResourceApprovalRelationship> @HasApprovals {  get; }
	
	}
}

namespace Xbim.Ifc4.PropertyResource
{
	[ExpressType("IfcProperty", 5)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcProperty : IfcPropertyAbstraction, IIfcProperty, IEquatable<@IfcProperty>
	{
		#region IIfcProperty explicit implementation
		IfcIdentifier IIfcProperty.Name { 
			get { return @Name; } 
 
			set { Name = value;}
		}	
		IfcText? IIfcProperty.Description { 
			get { return @Description; } 
 
			set { Description = value;}
		}	
		 
		IEnumerable<IIfcPropertySet> IIfcProperty.PartOfPset {  get { return @PartOfPset; } }
		IEnumerable<IIfcPropertyDependencyRelationship> IIfcProperty.PropertyForDependance {  get { return @PropertyForDependance; } }
		IEnumerable<IIfcPropertyDependencyRelationship> IIfcProperty.PropertyDependsOn {  get { return @PropertyDependsOn; } }
		IEnumerable<IIfcComplexProperty> IIfcProperty.PartOfComplex {  get { return @PartOfComplex; } }
		IEnumerable<IIfcResourceConstraintRelationship> IIfcProperty.HasConstraints {  get { return @HasConstraints; } }
		IEnumerable<IIfcResourceApprovalRelationship> IIfcProperty.HasApprovals {  get { return @HasApprovals; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProperty(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _name;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcIdentifier @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("HasProperties")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 4)]
		public IEnumerable<IfcPropertySet> @PartOfPset 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertySet>(e => e.HasProperties != null &&  e.HasProperties.Contains(this), "HasProperties", this);
			} 
		}
		[InverseProperty("DependingProperty")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 5)]
		public IEnumerable<IfcPropertyDependencyRelationship> @PropertyForDependance 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertyDependencyRelationship>(e => Equals(e.DependingProperty), "DependingProperty", this);
			} 
		}
		[InverseProperty("DependantProperty")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 6)]
		public IEnumerable<IfcPropertyDependencyRelationship> @PropertyDependsOn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPropertyDependencyRelationship>(e => Equals(e.DependantProperty), "DependantProperty", this);
			} 
		}
		[InverseProperty("HasProperties")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 7)]
		public IEnumerable<IfcComplexProperty> @PartOfComplex 
		{ 
			get 
			{
				return Model.Instances.Where<IfcComplexProperty>(e => e.HasProperties != null &&  e.HasProperties.Contains(this), "HasProperties", this);
			} 
		}
		[InverseProperty("RelatedResourceObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcResourceConstraintRelationship> @HasConstraints 
		{ 
			get 
			{
				return Model.Instances.Where<IfcResourceConstraintRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		[InverseProperty("RelatedResourceObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcResourceApprovalRelationship> @HasApprovals 
		{ 
			get 
			{
				return Model.Instances.Where<IfcResourceApprovalRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProperty other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProperty
            var root = (@IfcProperty)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProperty left, @IfcProperty right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProperty left, @IfcProperty right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
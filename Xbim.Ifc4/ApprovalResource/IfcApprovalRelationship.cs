// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ApprovalResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApprovalRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApprovalRelationship : IIfcResourceLevelRelationship
	{
		IIfcApproval @RelatingApproval { get; }
		IEnumerable<IIfcApproval> @RelatedApprovals { get; }
	
	}
}

namespace Xbim.Ifc4.ApprovalResource
{
	[IndexedClass]
	[ExpressType("IfcApprovalRelationship", 419)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcApprovalRelationship, IEqualityComparer<@IfcApprovalRelationship>, IEquatable<@IfcApprovalRelationship>
	{
		#region IIfcApprovalRelationship explicit implementation
		IIfcApproval IIfcApprovalRelationship.RelatingApproval { get { return @RelatingApproval; } }	
		IEnumerable<IIfcApproval> IIfcApprovalRelationship.RelatedApprovals { get { return @RelatedApprovals; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApprovalRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedApprovals = new ItemSet<IfcApproval>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcApproval _relatingApproval;
		private ItemSet<IfcApproval> _relatedApprovals;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingApproval;
				((IPersistEntity)this).Activate(false);
				return _relatingApproval;
			} 
			set
			{
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcApproval> @RelatedApprovals 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedApprovals;
				((IPersistEntity)this).Activate(false);
				return _relatedApprovals;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_relatingApproval = (IfcApproval)(value.EntityVal);
					return;
				case 3: 
					if (_relatedApprovals == null) _relatedApprovals = new ItemSet<IfcApproval>( this );
					_relatedApprovals.InternalAdd((IfcApproval)value.EntityVal);
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
        public bool Equals(@IfcApprovalRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcApprovalRelationship
            var root = (@IfcApprovalRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcApprovalRelationship left, @IfcApprovalRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcApprovalRelationship left, @IfcApprovalRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcApprovalRelationship x, @IfcApprovalRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcApprovalRelationship obj)
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
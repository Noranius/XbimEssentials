// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFacetedBrepWithVoids
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFacetedBrepWithVoids : IIfcManifoldSolidBrep
	{
		IEnumerable<IIfcClosedShell> @Voids { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcFacetedBrepWithVoids", 369)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFacetedBrepWithVoids : IfcManifoldSolidBrep, IInstantiableEntity, IIfcFacetedBrepWithVoids, IEqualityComparer<@IfcFacetedBrepWithVoids>, IEquatable<@IfcFacetedBrepWithVoids>
	{
		#region IIfcFacetedBrepWithVoids explicit implementation
		IEnumerable<IIfcClosedShell> IIfcFacetedBrepWithVoids.Voids { get { return @Voids; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFacetedBrepWithVoids(IModel model) : base(model) 		{ 
			Model = model; 
			_voids = new ItemSet<IfcClosedShell>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcClosedShell> _voids;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcClosedShell> @Voids 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _voids;
				((IPersistEntity)this).Activate(false);
				return _voids;
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
					if (_voids == null) _voids = new ItemSet<IfcClosedShell>( this );
					_voids.InternalAdd((IfcClosedShell)value.EntityVal);
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
        public bool Equals(@IfcFacetedBrepWithVoids other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFacetedBrepWithVoids
            var root = (@IfcFacetedBrepWithVoids)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFacetedBrepWithVoids left, @IfcFacetedBrepWithVoids right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFacetedBrepWithVoids left, @IfcFacetedBrepWithVoids right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFacetedBrepWithVoids x, @IfcFacetedBrepWithVoids y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFacetedBrepWithVoids obj)
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
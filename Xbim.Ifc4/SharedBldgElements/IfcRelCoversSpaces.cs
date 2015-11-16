// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelCoversSpaces
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelCoversSpaces : IIfcRelConnects
	{
		IIfcSpace @RelatingSpace { get; }
		IEnumerable<IIfcCovering> @RelatedCoverings { get; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgElements
{
	[ExpressType("IfcRelCoversSpaces", 936)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelCoversSpaces : IfcRelConnects, IInstantiableEntity, IIfcRelCoversSpaces, IEqualityComparer<@IfcRelCoversSpaces>, IEquatable<@IfcRelCoversSpaces>
	{
		#region IIfcRelCoversSpaces explicit implementation
		IIfcSpace IIfcRelCoversSpaces.RelatingSpace { get { return @RelatingSpace; } }	
		IEnumerable<IIfcCovering> IIfcRelCoversSpaces.RelatedCoverings { get { return @RelatedCoverings; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelCoversSpaces(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedCoverings = new ItemSet<IfcCovering>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcSpace _relatingSpace;
		private ItemSet<IfcCovering> _relatedCoverings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSpace @RelatingSpace 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingSpace;
				((IPersistEntity)this).Activate(false);
				return _relatingSpace;
			} 
			set
			{
				SetValue( v =>  _relatingSpace = v, _relatingSpace, value,  "RelatingSpace");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcCovering> @RelatedCoverings 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedCoverings;
				((IPersistEntity)this).Activate(false);
				return _relatedCoverings;
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
					_relatingSpace = (IfcSpace)(value.EntityVal);
					return;
				case 5: 
					if (_relatedCoverings == null) _relatedCoverings = new ItemSet<IfcCovering>( this );
					_relatedCoverings.InternalAdd((IfcCovering)value.EntityVal);
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
        public bool Equals(@IfcRelCoversSpaces other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelCoversSpaces
            var root = (@IfcRelCoversSpaces)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelCoversSpaces left, @IfcRelCoversSpaces right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelCoversSpaces left, @IfcRelCoversSpaces right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelCoversSpaces x, @IfcRelCoversSpaces y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelCoversSpaces obj)
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
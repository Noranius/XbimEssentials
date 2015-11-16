// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.RepresentationResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGeometricRepresentationContext
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGeometricRepresentationContext : IIfcRepresentationContext
	{
		IfcDimensionCount @CoordinateSpaceDimension { get; }
		double? @Precision { get; }
		IIfcAxis2Placement @WorldCoordinateSystem { get; }
		IIfcDirection @TrueNorth { get; }
		IEnumerable<IIfcGeometricRepresentationSubContext> @HasSubContexts {  get; }
	
	}
}

namespace Xbim.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcGeometricRepresentationContext", 555)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeometricRepresentationContext : IfcRepresentationContext, IInstantiableEntity, IIfcGeometricRepresentationContext, IEqualityComparer<@IfcGeometricRepresentationContext>, IEquatable<@IfcGeometricRepresentationContext>
	{
		#region IIfcGeometricRepresentationContext explicit implementation
		IfcDimensionCount IIfcGeometricRepresentationContext.CoordinateSpaceDimension { get { return @CoordinateSpaceDimension; } }	
		double? IIfcGeometricRepresentationContext.Precision { get { return @Precision; } }	
		IIfcAxis2Placement IIfcGeometricRepresentationContext.WorldCoordinateSystem { get { return @WorldCoordinateSystem; } }	
		IIfcDirection IIfcGeometricRepresentationContext.TrueNorth { get { return @TrueNorth; } }	
		 
		IEnumerable<IIfcGeometricRepresentationSubContext> IIfcGeometricRepresentationContext.HasSubContexts {  get { return @HasSubContexts; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationContext(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDimensionCount _coordinateSpaceDimension;
		private double? _precision;
		private IfcAxis2Placement _worldCoordinateSystem;
		private IfcDirection _trueNorth;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public virtual IfcDimensionCount @CoordinateSpaceDimension 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinateSpaceDimension;
				((IPersistEntity)this).Activate(false);
				return _coordinateSpaceDimension;
			} 
			set
			{
				SetValue( v =>  _coordinateSpaceDimension = v, _coordinateSpaceDimension, value,  "CoordinateSpaceDimension");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public virtual double? @Precision 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _precision;
				((IPersistEntity)this).Activate(false);
				return _precision;
			} 
			set
			{
				SetValue( v =>  _precision = v, _precision, value,  "Precision");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public virtual IfcAxis2Placement @WorldCoordinateSystem 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _worldCoordinateSystem;
				((IPersistEntity)this).Activate(false);
				return _worldCoordinateSystem;
			} 
			set
			{
				SetValue( v =>  _worldCoordinateSystem = v, _worldCoordinateSystem, value,  "WorldCoordinateSystem");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public virtual IfcDirection @TrueNorth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _trueNorth;
				((IPersistEntity)this).Activate(false);
				return _trueNorth;
			} 
			set
			{
				SetValue( v =>  _trueNorth = v, _trueNorth, value,  "TrueNorth");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcGeometricRepresentationSubContext> @HasSubContexts 
		{ 
			get 
			{
				return Model.Instances.Where<IfcGeometricRepresentationSubContext>(e => (e.ParentContext as IfcGeometricRepresentationContext) == this);
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
					_coordinateSpaceDimension = value.IntegerVal;
					return;
				case 3: 
					_precision = value.RealVal;
					return;
				case 4: 
					_worldCoordinateSystem = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 5: 
					_trueNorth = (IfcDirection)(value.EntityVal);
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
        public bool Equals(@IfcGeometricRepresentationContext other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGeometricRepresentationContext
            var root = (@IfcGeometricRepresentationContext)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGeometricRepresentationContext left, @IfcGeometricRepresentationContext right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGeometricRepresentationContext left, @IfcGeometricRepresentationContext right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcGeometricRepresentationContext x, @IfcGeometricRepresentationContext y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcGeometricRepresentationContext obj)
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
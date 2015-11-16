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
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBSplineCurveWithKnots
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBSplineCurveWithKnots : IIfcBSplineCurve
	{
		IEnumerable<IfcInteger> @KnotMultiplicities { get; }
		IEnumerable<IfcParameterValue> @Knots { get; }
		IfcKnotType @KnotSpec { get; }
		IfcInteger @UpperIndexOnKnots  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcBSplineCurveWithKnots", 431)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBSplineCurveWithKnots : IfcBSplineCurve, IInstantiableEntity, IIfcBSplineCurveWithKnots, IEqualityComparer<@IfcBSplineCurveWithKnots>, IEquatable<@IfcBSplineCurveWithKnots>
	{
		#region IIfcBSplineCurveWithKnots explicit implementation
		IEnumerable<IfcInteger> IIfcBSplineCurveWithKnots.KnotMultiplicities { get { return @KnotMultiplicities; } }	
		IEnumerable<IfcParameterValue> IIfcBSplineCurveWithKnots.Knots { get { return @Knots; } }	
		IfcKnotType IIfcBSplineCurveWithKnots.KnotSpec { get { return @KnotSpec; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBSplineCurveWithKnots(IModel model) : base(model) 		{ 
			Model = model; 
			_knotMultiplicities = new ItemSet<IfcInteger>( this, 0 );
			_knots = new ItemSet<IfcParameterValue>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcInteger> _knotMultiplicities;
		private ItemSet<IfcParameterValue> _knots;
		private IfcKnotType _knotSpec;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcInteger> @KnotMultiplicities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _knotMultiplicities;
				((IPersistEntity)this).Activate(false);
				return _knotMultiplicities;
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1)]
		public ItemSet<IfcParameterValue> @Knots 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _knots;
				((IPersistEntity)this).Activate(false);
				return _knots;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcKnotType @KnotSpec 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _knotSpec;
				((IPersistEntity)this).Activate(false);
				return _knotSpec;
			} 
			set
			{
				SetValue( v =>  _knotSpec = v, _knotSpec, value,  "KnotSpec");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcInteger @UpperIndexOnKnots 
		{
			get 
			{
				//## Getter for UpperIndexOnKnots
			    return Knots.Count;
			    //##
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
					if (_knotMultiplicities == null) _knotMultiplicities = new ItemSet<IfcInteger>( this );
					_knotMultiplicities.InternalAdd(value.IntegerVal);
					return;
				case 6: 
					if (_knots == null) _knots = new ItemSet<IfcParameterValue>( this );
					_knots.InternalAdd(value.RealVal);
					return;
				case 7: 
                    _knotSpec = (IfcKnotType) System.Enum.Parse(typeof (IfcKnotType), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ConsistentBSpline:UpperIndexOnControlPoints, KnotMultiplicities, Knots);*/
		/*CorrespondingKnotLists:	CorrespondingKnotLists : SIZEOF(KnotMultiplicities) = UpperIndexOnKnots;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBSplineCurveWithKnots other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBSplineCurveWithKnots
            var root = (@IfcBSplineCurveWithKnots)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBSplineCurveWithKnots left, @IfcBSplineCurveWithKnots right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBSplineCurveWithKnots left, @IfcBSplineCurveWithKnots right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBSplineCurveWithKnots x, @IfcBSplineCurveWithKnots y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBSplineCurveWithKnots obj)
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
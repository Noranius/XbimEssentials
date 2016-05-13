// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSweptDiskSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSweptDiskSolid : IIfcSolidModel
	{
		IIfcCurve @Directrix { get;  set; }
		IfcPositiveLengthMeasure @Radius { get;  set; }
		IfcPositiveLengthMeasure? @InnerRadius { get;  set; }
		IfcParameterValue? @StartParam { get;  set; }
		IfcParameterValue? @EndParam { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcSweptDiskSolid", 547)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSweptDiskSolid : IfcSolidModel, IInstantiableEntity, IIfcSweptDiskSolid, IContainsEntityReferences, IEquatable<@IfcSweptDiskSolid>
	{
		#region IIfcSweptDiskSolid explicit implementation
		IIfcCurve IIfcSweptDiskSolid.Directrix { 
			get { return @Directrix; } 
 
 
			set { Directrix = value as IfcCurve;}
		}	
		IfcPositiveLengthMeasure IIfcSweptDiskSolid.Radius { 
			get { return @Radius; } 
 
			set { Radius = value;}
		}	
		IfcPositiveLengthMeasure? IIfcSweptDiskSolid.InnerRadius { 
			get { return @InnerRadius; } 
 
			set { InnerRadius = value;}
		}	
		IfcParameterValue? IIfcSweptDiskSolid.StartParam { 
			get { return @StartParam; } 
 
			set { StartParam = value;}
		}	
		IfcParameterValue? IIfcSweptDiskSolid.EndParam { 
			get { return @EndParam; } 
 
			set { EndParam = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptDiskSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcPositiveLengthMeasure _radius;
		private IfcPositiveLengthMeasure? _innerRadius;
		private IfcParameterValue? _startParam;
		private IfcParameterValue? _endParam;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _directrix;
				((IPersistEntity)this).Activate(false);
				return _directrix;
			} 
			set
			{
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _radius;
				((IPersistEntity)this).Activate(false);
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure? @InnerRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _innerRadius;
				((IPersistEntity)this).Activate(false);
				return _innerRadius;
			} 
			set
			{
				SetValue( v =>  _innerRadius = v, _innerRadius, value,  "InnerRadius", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcParameterValue? @StartParam 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startParam;
				((IPersistEntity)this).Activate(false);
				return _startParam;
			} 
			set
			{
				SetValue( v =>  _startParam = v, _startParam, value,  "StartParam", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcParameterValue? @EndParam 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _endParam;
				((IPersistEntity)this).Activate(false);
				return _endParam;
			} 
			set
			{
				SetValue( v =>  _endParam = v, _endParam, value,  "EndParam", 5);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_radius = value.RealVal;
					return;
				case 2: 
					_innerRadius = value.RealVal;
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptDiskSolid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSweptDiskSolid
            var root = (@IfcSweptDiskSolid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSweptDiskSolid left, @IfcSweptDiskSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSweptDiskSolid left, @IfcSweptDiskSolid right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Directrix != null)
					yield return @Directrix;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
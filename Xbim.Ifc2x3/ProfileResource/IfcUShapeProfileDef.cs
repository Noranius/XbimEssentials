// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcUShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcUShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @Depth { get;  set; }
		IfcPositiveLengthMeasure @FlangeWidth { get;  set; }
		IfcPositiveLengthMeasure @WebThickness { get;  set; }
		IfcPositiveLengthMeasure @FlangeThickness { get;  set; }
		IfcPositiveLengthMeasure? @FilletRadius { get;  set; }
		IfcPositiveLengthMeasure? @EdgeRadius { get;  set; }
		IfcPlaneAngleMeasure? @FlangeSlope { get;  set; }
		IfcPositiveLengthMeasure? @CentreOfGravityInX { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcUShapeProfileDef", 670)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcUShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcUShapeProfileDef, IContainsEntityReferences, IEquatable<@IfcUShapeProfileDef>
	{
		#region IIfcUShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcUShapeProfileDef.Depth { 
			get { return @Depth; } 
 
			set { Depth = value;}
		}	
		IfcPositiveLengthMeasure IIfcUShapeProfileDef.FlangeWidth { 
			get { return @FlangeWidth; } 
 
			set { FlangeWidth = value;}
		}	
		IfcPositiveLengthMeasure IIfcUShapeProfileDef.WebThickness { 
			get { return @WebThickness; } 
 
			set { WebThickness = value;}
		}	
		IfcPositiveLengthMeasure IIfcUShapeProfileDef.FlangeThickness { 
			get { return @FlangeThickness; } 
 
			set { FlangeThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcUShapeProfileDef.FilletRadius { 
			get { return @FilletRadius; } 
 
			set { FilletRadius = value;}
		}	
		IfcPositiveLengthMeasure? IIfcUShapeProfileDef.EdgeRadius { 
			get { return @EdgeRadius; } 
 
			set { EdgeRadius = value;}
		}	
		IfcPlaneAngleMeasure? IIfcUShapeProfileDef.FlangeSlope { 
			get { return @FlangeSlope; } 
 
			set { FlangeSlope = value;}
		}	
		IfcPositiveLengthMeasure? IIfcUShapeProfileDef.CentreOfGravityInX { 
			get { return @CentreOfGravityInX; } 
 
			set { CentreOfGravityInX = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcUShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _flangeWidth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcPositiveLengthMeasure? _filletRadius;
		private IfcPositiveLengthMeasure? _edgeRadius;
		private IfcPlaneAngleMeasure? _flangeSlope;
		private IfcPositiveLengthMeasure? _centreOfGravityInX;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _depth;
				((IPersistEntity)this).Activate(false);
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure @FlangeWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flangeWidth;
				((IPersistEntity)this).Activate(false);
				return _flangeWidth;
			} 
			set
			{
				SetValue( v =>  _flangeWidth = v, _flangeWidth, value,  "FlangeWidth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _webThickness;
				((IPersistEntity)this).Activate(false);
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcPositiveLengthMeasure @FlangeThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flangeThickness;
				((IPersistEntity)this).Activate(false);
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcPositiveLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _filletRadius;
				((IPersistEntity)this).Activate(false);
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcPositiveLengthMeasure? @EdgeRadius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edgeRadius;
				((IPersistEntity)this).Activate(false);
				return _edgeRadius;
			} 
			set
			{
				SetValue( v =>  _edgeRadius = v, _edgeRadius, value,  "EdgeRadius", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcPlaneAngleMeasure? @FlangeSlope 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _flangeSlope;
				((IPersistEntity)this).Activate(false);
				return _flangeSlope;
			} 
			set
			{
				SetValue( v =>  _flangeSlope = v, _flangeSlope, value,  "FlangeSlope", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInX;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInX;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInX = v, _centreOfGravityInX, value,  "CentreOfGravityInX", 11);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_depth = value.RealVal;
					return;
				case 4: 
					_flangeWidth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_flangeThickness = value.RealVal;
					return;
				case 7: 
					_filletRadius = value.RealVal;
					return;
				case 8: 
					_edgeRadius = value.RealVal;
					return;
				case 9: 
					_flangeSlope = value.RealVal;
					return;
				case 10: 
					_centreOfGravityInX = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcUShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcUShapeProfileDef
            var root = (@IfcUShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcUShapeProfileDef left, @IfcUShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcUShapeProfileDef left, @IfcUShapeProfileDef right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
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
using Xbim.Ifc4.StructuralElementsDomain;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcingMeshType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcingMeshType : IIfcReinforcingElementType
	{
		IfcReinforcingMeshTypeEnum @PredefinedType { get; }
		IfcPositiveLengthMeasure? @MeshLength { get; }
		IfcPositiveLengthMeasure? @MeshWidth { get; }
		IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter { get; }
		IfcPositiveLengthMeasure? @TransverseBarNominalDiameter { get; }
		IfcAreaMeasure? @LongitudinalBarCrossSectionArea { get; }
		IfcAreaMeasure? @TransverseBarCrossSectionArea { get; }
		IfcPositiveLengthMeasure? @LongitudinalBarSpacing { get; }
		IfcPositiveLengthMeasure? @TransverseBarSpacing { get; }
		IfcLabel? @BendingShapeCode { get; }
		IEnumerable<IIfcBendingParameterSelect> @BendingParameters { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcReinforcingMeshType", 908)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcReinforcingMeshType : IfcReinforcingElementType, IInstantiableEntity, IIfcReinforcingMeshType, IEqualityComparer<@IfcReinforcingMeshType>, IEquatable<@IfcReinforcingMeshType>
	{
		#region IIfcReinforcingMeshType explicit implementation
		IfcReinforcingMeshTypeEnum IIfcReinforcingMeshType.PredefinedType { get { return @PredefinedType; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.MeshLength { get { return @MeshLength; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.MeshWidth { get { return @MeshWidth; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.LongitudinalBarNominalDiameter { get { return @LongitudinalBarNominalDiameter; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.TransverseBarNominalDiameter { get { return @TransverseBarNominalDiameter; } }	
		IfcAreaMeasure? IIfcReinforcingMeshType.LongitudinalBarCrossSectionArea { get { return @LongitudinalBarCrossSectionArea; } }	
		IfcAreaMeasure? IIfcReinforcingMeshType.TransverseBarCrossSectionArea { get { return @TransverseBarCrossSectionArea; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.LongitudinalBarSpacing { get { return @LongitudinalBarSpacing; } }	
		IfcPositiveLengthMeasure? IIfcReinforcingMeshType.TransverseBarSpacing { get { return @TransverseBarSpacing; } }	
		IfcLabel? IIfcReinforcingMeshType.BendingShapeCode { get { return @BendingShapeCode; } }	
		IEnumerable<IIfcBendingParameterSelect> IIfcReinforcingMeshType.BendingParameters { get { return @BendingParameters; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingMeshType(IModel model) : base(model) 		{ 
			Model = model; 
			_bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcReinforcingMeshTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _meshLength;
		private IfcPositiveLengthMeasure? _meshWidth;
		private IfcPositiveLengthMeasure? _longitudinalBarNominalDiameter;
		private IfcPositiveLengthMeasure? _transverseBarNominalDiameter;
		private IfcAreaMeasure? _longitudinalBarCrossSectionArea;
		private IfcAreaMeasure? _transverseBarCrossSectionArea;
		private IfcPositiveLengthMeasure? _longitudinalBarSpacing;
		private IfcPositiveLengthMeasure? _transverseBarSpacing;
		private IfcLabel? _bendingShapeCode;
		private OptionalItemSet<IfcBendingParameterSelect> _bendingParameters;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcReinforcingMeshTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MeshLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _meshLength;
				((IPersistEntity)this).Activate(false);
				return _meshLength;
			} 
			set
			{
				SetValue( v =>  _meshLength = v, _meshLength, value,  "MeshLength");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @MeshWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _meshWidth;
				((IPersistEntity)this).Activate(false);
				return _meshWidth;
			} 
			set
			{
				SetValue( v =>  _meshWidth = v, _meshWidth, value,  "MeshWidth");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LongitudinalBarNominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarNominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarNominalDiameter = v, _longitudinalBarNominalDiameter, value,  "LongitudinalBarNominalDiameter");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TransverseBarNominalDiameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarNominalDiameter;
				((IPersistEntity)this).Activate(false);
				return _transverseBarNominalDiameter;
			} 
			set
			{
				SetValue( v =>  _transverseBarNominalDiameter = v, _transverseBarNominalDiameter, value,  "TransverseBarNominalDiameter");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @LongitudinalBarCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarCrossSectionArea = v, _longitudinalBarCrossSectionArea, value,  "LongitudinalBarCrossSectionArea");
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcAreaMeasure? @TransverseBarCrossSectionArea 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarCrossSectionArea;
				((IPersistEntity)this).Activate(false);
				return _transverseBarCrossSectionArea;
			} 
			set
			{
				SetValue( v =>  _transverseBarCrossSectionArea = v, _transverseBarCrossSectionArea, value,  "TransverseBarCrossSectionArea");
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LongitudinalBarSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longitudinalBarSpacing;
				((IPersistEntity)this).Activate(false);
				return _longitudinalBarSpacing;
			} 
			set
			{
				SetValue( v =>  _longitudinalBarSpacing = v, _longitudinalBarSpacing, value,  "LongitudinalBarSpacing");
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TransverseBarSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transverseBarSpacing;
				((IPersistEntity)this).Activate(false);
				return _transverseBarSpacing;
			} 
			set
			{
				SetValue( v =>  _transverseBarSpacing = v, _transverseBarSpacing, value,  "TransverseBarSpacing");
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @BendingShapeCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _bendingShapeCode;
				((IPersistEntity)this).Activate(false);
				return _bendingShapeCode;
			} 
			set
			{
				SetValue( v =>  _bendingShapeCode = v, _bendingShapeCode, value,  "BendingShapeCode");
			} 
		}	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcBendingParameterSelect> @BendingParameters 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _bendingParameters;
				((IPersistEntity)this).Activate(false);
				return _bendingParameters;
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcReinforcingMeshTypeEnum) System.Enum.Parse(typeof (IfcReinforcingMeshTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_meshLength = value.RealVal;
					return;
				case 11: 
					_meshWidth = value.RealVal;
					return;
				case 12: 
					_longitudinalBarNominalDiameter = value.RealVal;
					return;
				case 13: 
					_transverseBarNominalDiameter = value.RealVal;
					return;
				case 14: 
					_longitudinalBarCrossSectionArea = value.RealVal;
					return;
				case 15: 
					_transverseBarCrossSectionArea = value.RealVal;
					return;
				case 16: 
					_longitudinalBarSpacing = value.RealVal;
					return;
				case 17: 
					_transverseBarSpacing = value.RealVal;
					return;
				case 18: 
					_bendingShapeCode = value.StringVal;
					return;
				case 19: 
					if (_bendingParameters == null) _bendingParameters = new OptionalItemSet<IfcBendingParameterSelect>( this );
					_bendingParameters.InternalAdd((IfcBendingParameterSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:((PredefinedType = IfcReinforcingMeshTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		/*BendingShapeCodeProvided:	BendingShapeCodeProvided : NOT EXISTS(BendingParameters) OR EXISTS(BendingShapeCode);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingMeshType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcReinforcingMeshType
            var root = (@IfcReinforcingMeshType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcReinforcingMeshType left, @IfcReinforcingMeshType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcReinforcingMeshType left, @IfcReinforcingMeshType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcReinforcingMeshType x, @IfcReinforcingMeshType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcReinforcingMeshType obj)
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
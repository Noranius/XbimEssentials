// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class @IfcMeasureWithUnit : IIfcMeasureWithUnit
	{
		IIfcValue IIfcMeasureWithUnit.ValueComponent 
		{ 
			get
			{
				if (ValueComponent == null) return null;
				if (ValueComponent is IfcVolumeMeasure) 
					return new Ifc4.MeasureResource.IfcVolumeMeasure((double)(IfcVolumeMeasure)ValueComponent);
				if (ValueComponent is IfcTimeMeasure) 
					return new Ifc4.MeasureResource.IfcTimeMeasure((double)(IfcTimeMeasure)ValueComponent);
				if (ValueComponent is IfcThermodynamicTemperatureMeasure) 
					return new Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure((double)(IfcThermodynamicTemperatureMeasure)ValueComponent);
				if (ValueComponent is IfcSolidAngleMeasure) 
					return new Ifc4.MeasureResource.IfcSolidAngleMeasure((double)(IfcSolidAngleMeasure)ValueComponent);
				if (ValueComponent is IfcPositiveRatioMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)(IfcPositiveRatioMeasure)ValueComponent);
				if (ValueComponent is IfcRatioMeasure) 
					return new Ifc4.MeasureResource.IfcRatioMeasure((double)(IfcRatioMeasure)ValueComponent);
				if (ValueComponent is IfcPositivePlaneAngleMeasure) 
					return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure((double)(IfcPositivePlaneAngleMeasure)ValueComponent);
				if (ValueComponent is IfcPlaneAngleMeasure) 
					return new Ifc4.MeasureResource.IfcPlaneAngleMeasure((double)(IfcPlaneAngleMeasure)ValueComponent);
				if (ValueComponent is IfcParameterValue) 
					return new Ifc4.MeasureResource.IfcParameterValue((double)(IfcParameterValue)ValueComponent);
				if (ValueComponent is IfcNumericMeasure) 
					return new Ifc4.MeasureResource.IfcNumericMeasure((double)(IfcNumericMeasure)ValueComponent);
				if (ValueComponent is IfcMassMeasure) 
					return new Ifc4.MeasureResource.IfcMassMeasure((double)(IfcMassMeasure)ValueComponent);
				if (ValueComponent is IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(IfcPositiveLengthMeasure)ValueComponent);
				if (ValueComponent is IfcLengthMeasure) 
					return new Ifc4.MeasureResource.IfcLengthMeasure((double)(IfcLengthMeasure)ValueComponent);
				if (ValueComponent is IfcElectricCurrentMeasure) 
					return new Ifc4.MeasureResource.IfcElectricCurrentMeasure((double)(IfcElectricCurrentMeasure)ValueComponent);
				if (ValueComponent is IfcDescriptiveMeasure) 
					return new Ifc4.MeasureResource.IfcDescriptiveMeasure((string)(IfcDescriptiveMeasure)ValueComponent);
				if (ValueComponent is IfcCountMeasure) 
					return new Ifc4.MeasureResource.IfcCountMeasure((double)(IfcCountMeasure)ValueComponent);
				if (ValueComponent is IfcContextDependentMeasure) 
					return new Ifc4.MeasureResource.IfcContextDependentMeasure((double)(IfcContextDependentMeasure)ValueComponent);
				if (ValueComponent is IfcAreaMeasure) 
					return new Ifc4.MeasureResource.IfcAreaMeasure((double)(IfcAreaMeasure)ValueComponent);
				if (ValueComponent is IfcAmountOfSubstanceMeasure) 
					return new Ifc4.MeasureResource.IfcAmountOfSubstanceMeasure((double)(IfcAmountOfSubstanceMeasure)ValueComponent);
				if (ValueComponent is IfcLuminousIntensityMeasure) 
					return new Ifc4.MeasureResource.IfcLuminousIntensityMeasure((double)(IfcLuminousIntensityMeasure)ValueComponent);
				if (ValueComponent is IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)(IfcNormalisedRatioMeasure)ValueComponent);
				if (ValueComponent is IfcComplexNumber) 
					return new Ifc4.MeasureResource.IfcComplexNumber((List<double>)(IfcComplexNumber)ValueComponent);
				if (ValueComponent is IfcInteger) 
					return new Ifc4.MeasureResource.IfcInteger((long)(IfcInteger)ValueComponent);
				if (ValueComponent is IfcReal) 
					return new Ifc4.MeasureResource.IfcReal((double)(IfcReal)ValueComponent);
				if (ValueComponent is IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((bool)(IfcBoolean)ValueComponent);
				if (ValueComponent is IfcIdentifier) 
					return new Ifc4.MeasureResource.IfcIdentifier((string)(IfcIdentifier)ValueComponent);
				if (ValueComponent is IfcText) 
					return new Ifc4.MeasureResource.IfcText((string)(IfcText)ValueComponent);
				if (ValueComponent is IfcLabel) 
					return new Ifc4.MeasureResource.IfcLabel((string)(IfcLabel)ValueComponent);
				if (ValueComponent is IfcLogical) 
					return new Ifc4.MeasureResource.IfcLogical((bool?)(IfcLogical)ValueComponent);
				if (ValueComponent is IfcVolumetricFlowRateMeasure) 
					return new Ifc4.MeasureResource.IfcVolumetricFlowRateMeasure((double)(IfcVolumetricFlowRateMeasure)ValueComponent);
				if (ValueComponent is IfcTimeStamp) 
					return new Ifc4.DateTimeResource.IfcTimeStamp((long)(IfcTimeStamp)ValueComponent);
				if (ValueComponent is IfcThermalTransmittanceMeasure) 
					return new Ifc4.MeasureResource.IfcThermalTransmittanceMeasure((double)(IfcThermalTransmittanceMeasure)ValueComponent);
				if (ValueComponent is IfcThermalResistanceMeasure) 
					return new Ifc4.MeasureResource.IfcThermalResistanceMeasure((double)(IfcThermalResistanceMeasure)ValueComponent);
				if (ValueComponent is IfcThermalAdmittanceMeasure) 
					return new Ifc4.MeasureResource.IfcThermalAdmittanceMeasure((double)(IfcThermalAdmittanceMeasure)ValueComponent);
				if (ValueComponent is IfcPressureMeasure) 
					return new Ifc4.MeasureResource.IfcPressureMeasure((double)(IfcPressureMeasure)ValueComponent);
				if (ValueComponent is IfcPowerMeasure) 
					return new Ifc4.MeasureResource.IfcPowerMeasure((double)(IfcPowerMeasure)ValueComponent);
				if (ValueComponent is IfcMassFlowRateMeasure) 
					return new Ifc4.MeasureResource.IfcMassFlowRateMeasure((double)(IfcMassFlowRateMeasure)ValueComponent);
				if (ValueComponent is IfcMassDensityMeasure) 
					return new Ifc4.MeasureResource.IfcMassDensityMeasure((double)(IfcMassDensityMeasure)ValueComponent);
				if (ValueComponent is IfcLinearVelocityMeasure) 
					return new Ifc4.MeasureResource.IfcLinearVelocityMeasure((double)(IfcLinearVelocityMeasure)ValueComponent);
				if (ValueComponent is IfcKinematicViscosityMeasure) 
					return new Ifc4.MeasureResource.IfcKinematicViscosityMeasure((double)(IfcKinematicViscosityMeasure)ValueComponent);
				if (ValueComponent is IfcIntegerCountRateMeasure) 
					return new Ifc4.MeasureResource.IfcIntegerCountRateMeasure((long)(IfcIntegerCountRateMeasure)ValueComponent);
				if (ValueComponent is IfcHeatFluxDensityMeasure) 
					return new Ifc4.MeasureResource.IfcHeatFluxDensityMeasure((double)(IfcHeatFluxDensityMeasure)ValueComponent);
				if (ValueComponent is IfcFrequencyMeasure) 
					return new Ifc4.MeasureResource.IfcFrequencyMeasure((double)(IfcFrequencyMeasure)ValueComponent);
				if (ValueComponent is IfcEnergyMeasure) 
					return new Ifc4.MeasureResource.IfcEnergyMeasure((double)(IfcEnergyMeasure)ValueComponent);
				if (ValueComponent is IfcElectricVoltageMeasure) 
					return new Ifc4.MeasureResource.IfcElectricVoltageMeasure((double)(IfcElectricVoltageMeasure)ValueComponent);
				if (ValueComponent is IfcDynamicViscosityMeasure) 
					return new Ifc4.MeasureResource.IfcDynamicViscosityMeasure((double)(IfcDynamicViscosityMeasure)ValueComponent);
				if (ValueComponent is IfcCompoundPlaneAngleMeasure) 
					return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure((List<long>)(IfcCompoundPlaneAngleMeasure)ValueComponent);
				if (ValueComponent is IfcAngularVelocityMeasure) 
					return new Ifc4.MeasureResource.IfcAngularVelocityMeasure((double)(IfcAngularVelocityMeasure)ValueComponent);
				if (ValueComponent is IfcThermalConductivityMeasure) 
					return new Ifc4.MeasureResource.IfcThermalConductivityMeasure((double)(IfcThermalConductivityMeasure)ValueComponent);
				if (ValueComponent is IfcMolecularWeightMeasure) 
					return new Ifc4.MeasureResource.IfcMolecularWeightMeasure((double)(IfcMolecularWeightMeasure)ValueComponent);
				if (ValueComponent is IfcVaporPermeabilityMeasure) 
					return new Ifc4.MeasureResource.IfcVaporPermeabilityMeasure((double)(IfcVaporPermeabilityMeasure)ValueComponent);
				if (ValueComponent is IfcMoistureDiffusivityMeasure) 
					return new Ifc4.MeasureResource.IfcMoistureDiffusivityMeasure((double)(IfcMoistureDiffusivityMeasure)ValueComponent);
				if (ValueComponent is IfcIsothermalMoistureCapacityMeasure) 
					return new Ifc4.MeasureResource.IfcIsothermalMoistureCapacityMeasure((double)(IfcIsothermalMoistureCapacityMeasure)ValueComponent);
				if (ValueComponent is IfcSpecificHeatCapacityMeasure) 
					return new Ifc4.MeasureResource.IfcSpecificHeatCapacityMeasure((double)(IfcSpecificHeatCapacityMeasure)ValueComponent);
				if (ValueComponent is IfcMonetaryMeasure) 
					return new Ifc4.MeasureResource.IfcMonetaryMeasure((double)(IfcMonetaryMeasure)ValueComponent);
				if (ValueComponent is IfcMagneticFluxDensityMeasure) 
					return new Ifc4.MeasureResource.IfcMagneticFluxDensityMeasure((double)(IfcMagneticFluxDensityMeasure)ValueComponent);
				if (ValueComponent is IfcMagneticFluxMeasure) 
					return new Ifc4.MeasureResource.IfcMagneticFluxMeasure((double)(IfcMagneticFluxMeasure)ValueComponent);
				if (ValueComponent is IfcLuminousFluxMeasure) 
					return new Ifc4.MeasureResource.IfcLuminousFluxMeasure((double)(IfcLuminousFluxMeasure)ValueComponent);
				if (ValueComponent is IfcForceMeasure) 
					return new Ifc4.MeasureResource.IfcForceMeasure((double)(IfcForceMeasure)ValueComponent);
				if (ValueComponent is IfcInductanceMeasure) 
					return new Ifc4.MeasureResource.IfcInductanceMeasure((double)(IfcInductanceMeasure)ValueComponent);
				if (ValueComponent is IfcIlluminanceMeasure) 
					return new Ifc4.MeasureResource.IfcIlluminanceMeasure((double)(IfcIlluminanceMeasure)ValueComponent);
				if (ValueComponent is IfcElectricResistanceMeasure) 
					return new Ifc4.MeasureResource.IfcElectricResistanceMeasure((double)(IfcElectricResistanceMeasure)ValueComponent);
				if (ValueComponent is IfcElectricConductanceMeasure) 
					return new Ifc4.MeasureResource.IfcElectricConductanceMeasure((double)(IfcElectricConductanceMeasure)ValueComponent);
				if (ValueComponent is IfcElectricChargeMeasure) 
					return new Ifc4.MeasureResource.IfcElectricChargeMeasure((double)(IfcElectricChargeMeasure)ValueComponent);
				if (ValueComponent is IfcDoseEquivalentMeasure) 
					return new Ifc4.MeasureResource.IfcDoseEquivalentMeasure((double)(IfcDoseEquivalentMeasure)ValueComponent);
				if (ValueComponent is IfcElectricCapacitanceMeasure) 
					return new Ifc4.MeasureResource.IfcElectricCapacitanceMeasure((double)(IfcElectricCapacitanceMeasure)ValueComponent);
				if (ValueComponent is IfcAbsorbedDoseMeasure) 
					return new Ifc4.MeasureResource.IfcAbsorbedDoseMeasure((double)(IfcAbsorbedDoseMeasure)ValueComponent);
				if (ValueComponent is IfcRadioActivityMeasure) 
					return new Ifc4.MeasureResource.IfcRadioActivityMeasure((double)(IfcRadioActivityMeasure)ValueComponent);
				if (ValueComponent is IfcRotationalFrequencyMeasure) 
					return new Ifc4.MeasureResource.IfcRotationalFrequencyMeasure((double)(IfcRotationalFrequencyMeasure)ValueComponent);
				if (ValueComponent is IfcTorqueMeasure) 
					return new Ifc4.MeasureResource.IfcTorqueMeasure((double)(IfcTorqueMeasure)ValueComponent);
				if (ValueComponent is IfcAccelerationMeasure) 
					return new Ifc4.MeasureResource.IfcAccelerationMeasure((double)(IfcAccelerationMeasure)ValueComponent);
				if (ValueComponent is IfcLinearForceMeasure) 
					return new Ifc4.MeasureResource.IfcLinearForceMeasure((double)(IfcLinearForceMeasure)ValueComponent);
				if (ValueComponent is IfcLinearStiffnessMeasure) 
					return new Ifc4.MeasureResource.IfcLinearStiffnessMeasure((double)(IfcLinearStiffnessMeasure)ValueComponent);
				if (ValueComponent is IfcModulusOfSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure((double)(IfcModulusOfSubgradeReactionMeasure)ValueComponent);
				if (ValueComponent is IfcModulusOfElasticityMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfElasticityMeasure((double)(IfcModulusOfElasticityMeasure)ValueComponent);
				if (ValueComponent is IfcMomentOfInertiaMeasure) 
					return new Ifc4.MeasureResource.IfcMomentOfInertiaMeasure((double)(IfcMomentOfInertiaMeasure)ValueComponent);
				if (ValueComponent is IfcPlanarForceMeasure) 
					return new Ifc4.MeasureResource.IfcPlanarForceMeasure((double)(IfcPlanarForceMeasure)ValueComponent);
				if (ValueComponent is IfcRotationalStiffnessMeasure) 
					return new Ifc4.MeasureResource.IfcRotationalStiffnessMeasure((double)(IfcRotationalStiffnessMeasure)ValueComponent);
				if (ValueComponent is IfcShearModulusMeasure) 
					return new Ifc4.MeasureResource.IfcShearModulusMeasure((double)(IfcShearModulusMeasure)ValueComponent);
				if (ValueComponent is IfcLinearMomentMeasure) 
					return new Ifc4.MeasureResource.IfcLinearMomentMeasure((double)(IfcLinearMomentMeasure)ValueComponent);
				if (ValueComponent is IfcLuminousIntensityDistributionMeasure) 
					return new Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure((double)(IfcLuminousIntensityDistributionMeasure)ValueComponent);
				if (ValueComponent is IfcCurvatureMeasure) 
					return new Ifc4.MeasureResource.IfcCurvatureMeasure((double)(IfcCurvatureMeasure)ValueComponent);
				if (ValueComponent is IfcMassPerLengthMeasure) 
					return new Ifc4.MeasureResource.IfcMassPerLengthMeasure((double)(IfcMassPerLengthMeasure)ValueComponent);
				if (ValueComponent is IfcModulusOfLinearSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((double)(IfcModulusOfLinearSubgradeReactionMeasure)ValueComponent);
				if (ValueComponent is IfcModulusOfRotationalSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((double)(IfcModulusOfRotationalSubgradeReactionMeasure)ValueComponent);
				if (ValueComponent is IfcRotationalMassMeasure) 
					return new Ifc4.MeasureResource.IfcRotationalMassMeasure((double)(IfcRotationalMassMeasure)ValueComponent);
				if (ValueComponent is IfcSectionalAreaIntegralMeasure) 
					return new Ifc4.MeasureResource.IfcSectionalAreaIntegralMeasure((double)(IfcSectionalAreaIntegralMeasure)ValueComponent);
				if (ValueComponent is IfcSectionModulusMeasure) 
					return new Ifc4.MeasureResource.IfcSectionModulusMeasure((double)(IfcSectionModulusMeasure)ValueComponent);
				if (ValueComponent is IfcTemperatureGradientMeasure) 
					return new Ifc4.MeasureResource.IfcTemperatureGradientMeasure((double)(IfcTemperatureGradientMeasure)ValueComponent);
				if (ValueComponent is IfcThermalExpansionCoefficientMeasure) 
					return new Ifc4.MeasureResource.IfcThermalExpansionCoefficientMeasure((double)(IfcThermalExpansionCoefficientMeasure)ValueComponent);
				if (ValueComponent is IfcWarpingConstantMeasure) 
					return new Ifc4.MeasureResource.IfcWarpingConstantMeasure((double)(IfcWarpingConstantMeasure)ValueComponent);
				if (ValueComponent is IfcWarpingMomentMeasure) 
					return new Ifc4.MeasureResource.IfcWarpingMomentMeasure((double)(IfcWarpingMomentMeasure)ValueComponent);
				if (ValueComponent is IfcSoundPowerMeasure) 
					return new Ifc4.MeasureResource.IfcSoundPowerMeasure((double)(IfcSoundPowerMeasure)ValueComponent);
				if (ValueComponent is IfcSoundPressureMeasure) 
					return new Ifc4.MeasureResource.IfcSoundPressureMeasure((double)(IfcSoundPressureMeasure)ValueComponent);
				if (ValueComponent is IfcHeatingValueMeasure) 
					return new Ifc4.MeasureResource.IfcHeatingValueMeasure((double)(IfcHeatingValueMeasure)ValueComponent);
				if (ValueComponent is IfcPHMeasure) 
					return new Ifc4.MeasureResource.IfcPHMeasure((double)(IfcPHMeasure)ValueComponent);
				if (ValueComponent is IfcIonConcentrationMeasure) 
					return new Ifc4.MeasureResource.IfcIonConcentrationMeasure((double)(IfcIonConcentrationMeasure)ValueComponent);
				return null;
			} 
			set
			{
				
			}
		}
		IIfcUnit IIfcMeasureWithUnit.UnitComponent 
		{ 
			get
			{
				if (UnitComponent == null) return null;
				var ifcderivedunit = UnitComponent as IfcDerivedUnit;
				if (ifcderivedunit != null) 
					return ifcderivedunit;
				var ifcnamedunit = UnitComponent as IfcNamedUnit;
				if (ifcnamedunit != null) 
					return ifcnamedunit;
				var ifcmonetaryunit = UnitComponent as IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
					return ifcmonetaryunit;
				return null;
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}
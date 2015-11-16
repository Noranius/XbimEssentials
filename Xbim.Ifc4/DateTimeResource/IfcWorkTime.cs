// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWorkTime
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWorkTime : IIfcSchedulingTime
	{
		IIfcRecurrencePattern @RecurrencePattern { get; }
		IfcDate? @Start { get; }
		IfcDate? @Finish { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcWorkTime", 1162)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkTime : IfcSchedulingTime, IInstantiableEntity, IIfcWorkTime, IEqualityComparer<@IfcWorkTime>, IEquatable<@IfcWorkTime>
	{
		#region IIfcWorkTime explicit implementation
		IIfcRecurrencePattern IIfcWorkTime.RecurrencePattern { get { return @RecurrencePattern; } }	
		IfcDate? IIfcWorkTime.Start { get { return @Start; } }	
		IfcDate? IIfcWorkTime.Finish { get { return @Finish; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkTime(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrencePattern;
		private IfcDate? _start;
		private IfcDate? _finish;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRecurrencePattern @RecurrencePattern 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _recurrencePattern;
				((IPersistEntity)this).Activate(false);
				return _recurrencePattern;
			} 
			set
			{
				SetValue( v =>  _recurrencePattern = v, _recurrencePattern, value,  "RecurrencePattern");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @Start 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _start;
				((IPersistEntity)this).Activate(false);
				return _start;
			} 
			set
			{
				SetValue( v =>  _start = v, _start, value,  "Start");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcDate? @Finish 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _finish;
				((IPersistEntity)this).Activate(false);
				return _finish;
			} 
			set
			{
				SetValue( v =>  _finish = v, _finish, value,  "Finish");
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
					_recurrencePattern = (IfcRecurrencePattern)(value.EntityVal);
					return;
				case 4: 
					_start = value.StringVal;
					return;
				case 5: 
					_finish = value.StringVal;
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
        public bool Equals(@IfcWorkTime other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWorkTime
            var root = (@IfcWorkTime)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWorkTime left, @IfcWorkTime right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWorkTime left, @IfcWorkTime right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcWorkTime x, @IfcWorkTime y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcWorkTime obj)
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
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.DateTimeResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRecurrencePattern
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRecurrencePattern : IPersistEntity
	{
		IfcRecurrenceTypeEnum @RecurrenceType { get; }
		IEnumerable<IfcDayInMonthNumber> @DayComponent { get; }
		IEnumerable<IfcDayInWeekNumber> @WeekdayComponent { get; }
		IEnumerable<IfcMonthInYearNumber> @MonthComponent { get; }
		IfcInteger? @Position { get; }
		IfcInteger? @Interval { get; }
		IfcInteger? @Occurrences { get; }
		IEnumerable<IIfcTimePeriod> @TimePeriods { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcRecurrencePattern", 898)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRecurrencePattern : INotifyPropertyChanged, IInstantiableEntity, IIfcRecurrencePattern, IEqualityComparer<@IfcRecurrencePattern>, IEquatable<@IfcRecurrencePattern>
	{
		#region IIfcRecurrencePattern explicit implementation
		IfcRecurrenceTypeEnum IIfcRecurrencePattern.RecurrenceType { get { return @RecurrenceType; } }	
		IEnumerable<IfcDayInMonthNumber> IIfcRecurrencePattern.DayComponent { get { return @DayComponent; } }	
		IEnumerable<IfcDayInWeekNumber> IIfcRecurrencePattern.WeekdayComponent { get { return @WeekdayComponent; } }	
		IEnumerable<IfcMonthInYearNumber> IIfcRecurrencePattern.MonthComponent { get { return @MonthComponent; } }	
		IfcInteger? IIfcRecurrencePattern.Position { get { return @Position; } }	
		IfcInteger? IIfcRecurrencePattern.Interval { get { return @Interval; } }	
		IfcInteger? IIfcRecurrencePattern.Occurrences { get { return @Occurrences; } }	
		IEnumerable<IIfcTimePeriod> IIfcRecurrencePattern.TimePeriods { get { return @TimePeriods; } }	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRecurrencePattern(IModel model) 		{ 
			Model = model; 
			_dayComponent = new OptionalItemSet<IfcDayInMonthNumber>( this, 0 );
			_weekdayComponent = new OptionalItemSet<IfcDayInWeekNumber>( this, 0 );
			_monthComponent = new OptionalItemSet<IfcMonthInYearNumber>( this, 0 );
			_timePeriods = new OptionalItemSet<IfcTimePeriod>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcRecurrenceTypeEnum _recurrenceType;
		private OptionalItemSet<IfcDayInMonthNumber> _dayComponent;
		private OptionalItemSet<IfcDayInWeekNumber> _weekdayComponent;
		private OptionalItemSet<IfcMonthInYearNumber> _monthComponent;
		private IfcInteger? _position;
		private IfcInteger? _interval;
		private IfcInteger? _occurrences;
		private OptionalItemSet<IfcTimePeriod> _timePeriods;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 1)]
		public IfcRecurrenceTypeEnum @RecurrenceType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _recurrenceType;
				((IPersistEntity)this).Activate(false);
				return _recurrenceType;
			} 
			set
			{
				SetValue( v =>  _recurrenceType = v, _recurrenceType, value,  "RecurrenceType");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, 1, -1, 2)]
		public OptionalItemSet<IfcDayInMonthNumber> @DayComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dayComponent;
				((IPersistEntity)this).Activate(false);
				return _dayComponent;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, 1, -1, 3)]
		public OptionalItemSet<IfcDayInWeekNumber> @WeekdayComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _weekdayComponent;
				((IPersistEntity)this).Activate(false);
				return _weekdayComponent;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.None, 1, -1, 4)]
		public OptionalItemSet<IfcMonthInYearNumber> @MonthComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _monthComponent;
				((IPersistEntity)this).Activate(false);
				return _monthComponent;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcInteger? @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcInteger? @Interval 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _interval;
				((IPersistEntity)this).Activate(false);
				return _interval;
			} 
			set
			{
				SetValue( v =>  _interval = v, _interval, value,  "Interval");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcInteger? @Occurrences 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _occurrences;
				((IPersistEntity)this).Activate(false);
				return _occurrences;
			} 
			set
			{
				SetValue( v =>  _occurrences = v, _occurrences, value,  "Occurrences");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 8)]
		public OptionalItemSet<IfcTimePeriod> @TimePeriods 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timePeriods;
				((IPersistEntity)this).Activate(false);
				return _timePeriods;
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _recurrenceType = (IfcRecurrenceTypeEnum) System.Enum.Parse(typeof (IfcRecurrenceTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					if (_dayComponent == null) _dayComponent = new OptionalItemSet<IfcDayInMonthNumber>( this );
					_dayComponent.InternalAdd(value.IntegerVal);
					return;
				case 2: 
					if (_weekdayComponent == null) _weekdayComponent = new OptionalItemSet<IfcDayInWeekNumber>( this );
					_weekdayComponent.InternalAdd(value.IntegerVal);
					return;
				case 3: 
					if (_monthComponent == null) _monthComponent = new OptionalItemSet<IfcMonthInYearNumber>( this );
					_monthComponent.InternalAdd(value.IntegerVal);
					return;
				case 4: 
					_position = value.IntegerVal;
					return;
				case 5: 
					_interval = value.IntegerVal;
					return;
				case 6: 
					_occurrences = value.IntegerVal;
					return;
				case 7: 
					if (_timePeriods == null) _timePeriods = new OptionalItemSet<IfcTimePeriod>( this );
					_timePeriods.InternalAdd((IfcTimePeriod)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRecurrencePattern other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRecurrencePattern
            var root = (@IfcRecurrencePattern)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRecurrencePattern left, @IfcRecurrencePattern right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRecurrencePattern left, @IfcRecurrencePattern right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRecurrencePattern x, @IfcRecurrencePattern y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRecurrencePattern obj)
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
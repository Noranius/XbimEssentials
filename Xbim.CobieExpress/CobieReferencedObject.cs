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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.CobieExpress
{
	[IndexedClass]
	[ExpressType("ReferencedObject", 13)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @CobieReferencedObject : IPersistEntity, INotifyPropertyChanged, IEqualityComparer<@CobieReferencedObject>, IEquatable<@CobieReferencedObject>
	{
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
		internal CobieReferencedObject(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _externalId;
		private CobieCreatedInfo _created;
		private CobieExternalSystem _externalSystem;
		private string _externalObject;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @ExternalId 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _externalId;
				((IPersistEntity)this).Activate(false);
				return _externalId;
			} 
			set
			{
				SetValue( v =>  _externalId = v, _externalId, value,  "ExternalId");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieCreatedInfo @Created 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _created;
				((IPersistEntity)this).Activate(false);
				return _created;
			} 
			set
			{
				SetValue( v =>  _created = v, _created, value,  "Created");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public CobieExternalSystem @ExternalSystem 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _externalSystem;
				((IPersistEntity)this).Activate(false);
				return _externalSystem;
			} 
			set
			{
				SetValue( v =>  _externalSystem = v, _externalSystem, value,  "ExternalSystem");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public string @ExternalObject 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _externalObject;
				((IPersistEntity)this).Activate(false);
				return _externalObject;
			} 
			set
			{
				SetValue( v =>  _externalObject = v, _externalObject, value,  "ExternalObject");
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
					_externalId = value.StringVal;
					return;
				case 1: 
					_created = (CobieCreatedInfo)(value.EntityVal);
					return;
				case 2: 
					_externalSystem = (CobieExternalSystem)(value.EntityVal);
					return;
				case 3: 
					_externalObject = value.StringVal;
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
        public bool Equals(@CobieReferencedObject other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieReferencedObject
            var root = (@CobieReferencedObject)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieReferencedObject left, @CobieReferencedObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieReferencedObject left, @CobieReferencedObject right)
        {
            return !(left == right);
        }


        public bool Equals(@CobieReferencedObject x, @CobieReferencedObject y)
        {
            return x == y;
        }

        public int GetHashCode(@CobieReferencedObject obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 11/5/2013
 * Time: 1:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Windows;

namespace UIAutomation
{
	using System;
	using System.Windows.Automation;
	using Ninject;

	/// <summary>
	/// Description of MySuperWrapper.
	/// </summary>
	public class MySuperWrapper : IMySuperWrapper
	{
		private AutomationElement _elementHolderNet;
		// //private AutomationElement _elementHolderCom;
		private IMySuperWrapper _elementHolderAdapter;
		private static InnerElementTypes _innerElementType = InnerElementTypes.Empty;
        
		[Inject]
		public MySuperWrapper(AutomationElement element)
		{
			_elementHolderNet = element;
			_innerElementType = InnerElementTypes.AutomationElementNet;
		}
		
		//[Inject]
		//public MySuperWrapper(::AutomationElement element)
		//{
		//	this._elementHolderCom = element;
		//}
		
		[Inject]
		public MySuperWrapper(IMySuperWrapper element)
		{
			_elementHolderAdapter = element;
			_innerElementType = InnerElementTypes.MySuperWrapper;
		}
		
		[Inject]
		public MySuperWrapper()
		{
			_innerElementType = InnerElementTypes.Empty;
		}

		public override bool Equals(object obj)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.Equals(obj);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.Equals(obj);
			    default:
			        return _elementHolderNet.Equals(obj);
			}
		}

		public override int GetHashCode()
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetHashCode();
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetHashCode();
			    default:
			        return _elementHolderNet.GetHashCode();
			}
		}

		public int[] GetRuntimeId()
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetRuntimeId();
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetRuntimeId();
			    default:
			        return _elementHolderNet.GetRuntimeId();
			}
		}

		public object GetCurrentPropertyValue(AutomationProperty property)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.GetCachedPropertyValue(property);
			        } else {
                        return _elementHolderNet.GetCurrentPropertyValue(property);
			        }
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        if (Preferences.FromCache) {
			            return _elementHolderAdapter.GetCachedPropertyValue(property);
			        } else {
                        return _elementHolderAdapter.GetCurrentPropertyValue(property);
			        }
			    default:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.GetCachedPropertyValue(property);
			        } else {
                        return _elementHolderNet.GetCurrentPropertyValue(property);
			        }
			}
		}

		public object GetCurrentPropertyValue(AutomationProperty property, bool ignoreDefaultValue)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.GetCachedPropertyValue(property, ignoreDefaultValue);
			        } else {
                        return _elementHolderNet.GetCurrentPropertyValue(property, ignoreDefaultValue);
			        }
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        if (Preferences.FromCache) {
			            return _elementHolderAdapter.GetCachedPropertyValue(property, ignoreDefaultValue);
			        } else {
                        return _elementHolderAdapter.GetCurrentPropertyValue(property, ignoreDefaultValue);
			        }
			    default:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.GetCachedPropertyValue(property, ignoreDefaultValue);
			        } else {
                        return _elementHolderNet.GetCurrentPropertyValue(property, ignoreDefaultValue);
			        }
			}
		}

		public object GetCurrentPattern(AutomationPattern pattern)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        if (Preferences.FromCache) {
                        // 20131122
                        // ValuePattern -> IMySuperValuePattern
		                if (pattern.Id == ValuePattern.Pattern.Id) {
		                //switch (pattern.Id) {
		                //    case (ValuePattern.Pattern.Id):
		                        //ValuePattern valuePattern =
		                        IMySuperValuePattern valuePattern =
		                            ObjectsFactory.GetMySuperValuePattern(
		                                this,
		                                _elementHolderNet.GetCachedPattern(pattern) as ValuePattern);//,
		                                //Preferences.FromCache);
		                        return valuePattern;
		                //    default:
		                //        
		                //    	break;
		                }
			            return _elementHolderNet.GetCachedPattern(pattern);
			        } else {
                        // 20131122
                        // ValuePattern -> IMySuperValuePattern
		                if (pattern.Id == ValuePattern.Pattern.Id) {
		                //switch (pattern.Id) {
		                //    case ValuePattern.Pattern.Id:
		                        //ValuePattern valuePattern =
		                        IMySuperValuePattern valuePattern =
		                            ObjectsFactory.GetMySuperValuePattern(
		                                this,
		                                _elementHolderNet.GetCurrentPattern(pattern) as ValuePattern);//,
		                                //Preferences.FromCache);
		                        return valuePattern;
		                //    default:
		                //        
		                //    	break;
		                }
                        return _elementHolderNet.GetCurrentPattern(pattern);
			        }
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        if (Preferences.FromCache) {
			            return _elementHolderAdapter.GetCachedPattern(pattern);
			        } else {
                        return _elementHolderAdapter.GetCurrentPattern(pattern);
			        }
			    default:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.GetCachedPattern(pattern);
			        } else {
                        return _elementHolderNet.GetCurrentPattern(pattern);
			        }
			}
		}

		public bool TryGetCurrentPattern(AutomationPattern pattern, out object patternObject)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.TryGetCachedPattern(pattern, out patternObject);
			        } else {
                        return _elementHolderNet.TryGetCurrentPattern(pattern, out patternObject);
			        }
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        if (Preferences.FromCache) {
			            return _elementHolderAdapter.TryGetCachedPattern(pattern, out patternObject);
			        } else {
                        return _elementHolderAdapter.TryGetCurrentPattern(pattern, out patternObject);
			        }
			    default:
			        if (Preferences.FromCache) {
			            return _elementHolderNet.TryGetCachedPattern(pattern, out patternObject);
			        } else {
                        return _elementHolderNet.TryGetCurrentPattern(pattern, out patternObject);
			        }
			}
		}

		public object GetCachedPropertyValue(AutomationProperty property)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetCachedPropertyValue(property);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetCachedPropertyValue(property);
			    default:
			        return _elementHolderNet.GetCachedPropertyValue(property);
			}
		}

		public object GetCachedPropertyValue(AutomationProperty property, bool ignoreDefaultValue)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetCachedPropertyValue(property, ignoreDefaultValue);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetCachedPropertyValue(property, ignoreDefaultValue);
			    default:
			        return _elementHolderNet.GetCachedPropertyValue(property, ignoreDefaultValue);
			}
		}

		public object GetCachedPattern(AutomationPattern pattern)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetCachedPattern(pattern);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetCachedPattern(pattern);
			    default:
			        return _elementHolderNet.GetCachedPattern(pattern);
			}
		}

		public bool TryGetCachedPattern(AutomationPattern pattern, out object patternObject)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.TryGetCachedPattern(pattern, out patternObject);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.TryGetCachedPattern(pattern, out patternObject);
			    default:
			        return _elementHolderNet.TryGetCachedPattern(pattern, out patternObject);
			}
		}

		public AutomationElement GetUpdatedCache(CacheRequest request)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetUpdatedCache(request);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetUpdatedCache(request);
			    default:
			        return _elementHolderNet.GetUpdatedCache(request);
			}
		}

		public IMySuperWrapper FindFirst(TreeScope scope, Condition condition)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return ObjectsFactory.GetMySuperWrapper(_elementHolderNet.FindFirst(scope, condition));
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.FindFirst(scope, condition);
			    default:
			        return ObjectsFactory.GetMySuperWrapper(_elementHolderNet.FindFirst(scope, condition));
			}
		}

		public IMySuperCollection FindAll(TreeScope scope, Condition condition)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return ObjectsFactory.GetMySuperCollection(_elementHolderNet.FindAll(scope, condition));
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.FindAll(scope, condition);
			    default:
			        return ObjectsFactory.GetMySuperCollection(_elementHolderNet.FindAll(scope, condition));
			}
		}

		public AutomationProperty[] GetSupportedProperties()
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetSupportedProperties();
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetSupportedProperties();
			    default:
			        return _elementHolderNet.GetSupportedProperties();
			}
		}

		public AutomationPattern[] GetSupportedPatterns()
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetSupportedPatterns();
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetSupportedPatterns();
			    default:
			        return _elementHolderNet.GetSupportedPatterns();
			}
		}

		public void SetFocus()
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        _elementHolderNet.SetFocus();
			        break;
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        _elementHolderAdapter.SetFocus();
			        break;
			    default:
			        _elementHolderNet.SetFocus();
			        break;
			}
		}

		public bool TryGetClickablePoint(out Point pt)
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.TryGetClickablePoint(out pt);
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.TryGetClickablePoint(out pt);
			    default:
			        return _elementHolderNet.TryGetClickablePoint(out pt);
			}
		}

		public Point GetClickablePoint()
		{
			switch (_innerElementType) {
			    case InnerElementTypes.AutomationElementNet:
			        return _elementHolderNet.GetClickablePoint();
//			    case InnerElementTypes.AutomationElementCom:
//			        //
			    case InnerElementTypes.MySuperWrapper:
			        return _elementHolderAdapter.GetClickablePoint();
			    default:
			        return _elementHolderNet.GetClickablePoint();
			}
		}

		public IMySuperWrapperInformation Cached {
			get {
			    switch (_innerElementType) {
			        case InnerElementTypes.AutomationElementNet:
			            return ObjectsFactory.GetMySuperWrapperInformation(_elementHolderNet.Cached);
//			        case /InnerElementTypes.AutomationElementCom:
//			            //
			        case InnerElementTypes.MySuperWrapper:
			            return _elementHolderAdapter.Cached;
			        default:
			            return ObjectsFactory.GetMySuperWrapperInformation(_elementHolderNet.Cached);
			    }
			}
		}

		public IMySuperWrapperInformation Current {
		    get {
		        switch (_innerElementType) {
		            case InnerElementTypes.AutomationElementNet:
		                if (Preferences.FromCache) {
                            return ObjectsFactory.GetMySuperWrapperInformation(_elementHolderNet.Cached);
    			        } else {
    		                return ObjectsFactory.GetMySuperWrapperInformation(_elementHolderNet.Current);
                        }
//		            case InnerElementTypes.AutomationElementCom:
//		                //
		            case InnerElementTypes.MySuperWrapper:
		                if (Preferences.FromCache) {
    			            return _elementHolderAdapter.Cached;
    			        } else {
                            return _elementHolderAdapter.Current;
		                }
		            default:
		                if (Preferences.FromCache) {
    			            return ObjectsFactory.GetMySuperWrapperInformation(_elementHolderNet.Cached);
    			        } else {
                            return ObjectsFactory.GetMySuperWrapperInformation(_elementHolderNet.Current);
		                }
		        }
		    }
		}

		public IMySuperWrapper CachedParent {
			get {
			    switch (_innerElementType) {
			        case InnerElementTypes.AutomationElementNet:
			            return ObjectsFactory.GetMySuperWrapper(_elementHolderNet.CachedParent);
//			        case InnerElementTypes.AutomationElementCom:
//			            //
			        case InnerElementTypes.MySuperWrapper:
			            return _elementHolderAdapter.CachedParent;
			        default:
			            return ObjectsFactory.GetMySuperWrapper(_elementHolderNet.CachedParent);
			    }
			}
		}

		public IMySuperCollection CachedChildren {
			get {
			    switch (_innerElementType) {
			        case InnerElementTypes.AutomationElementNet:
			            return ObjectsFactory.GetMySuperCollection(_elementHolderNet.CachedChildren);
//			        case /InnerElementTypes.AutomationElementCom:
//			            //
			        case InnerElementTypes.MySuperWrapper:
			            return _elementHolderAdapter.CachedChildren;
			        default:
			            return ObjectsFactory.GetMySuperCollection(_elementHolderNet.CachedChildren);
			    }
			}
		}

		// static methods and properties
		public static readonly object NotSupported = AutomationElementIdentifiers.NotSupported;
		public static readonly AutomationProperty IsControlElementProperty = AutomationElementIdentifiers.IsControlElementProperty;
		public static readonly AutomationProperty ControlTypeProperty = AutomationElementIdentifiers.ControlTypeProperty;
		public static readonly AutomationProperty IsContentElementProperty = AutomationElementIdentifiers.IsContentElementProperty;
		public static readonly AutomationProperty LabeledByProperty = AutomationElementIdentifiers.LabeledByProperty;
		public static readonly AutomationProperty NativeWindowHandleProperty = AutomationElementIdentifiers.NativeWindowHandleProperty;
		public static readonly AutomationProperty AutomationIdProperty = AutomationElementIdentifiers.AutomationIdProperty;
		public static readonly AutomationProperty ItemTypeProperty = AutomationElementIdentifiers.ItemTypeProperty;
		public static readonly AutomationProperty IsPasswordProperty = AutomationElementIdentifiers.IsPasswordProperty;
		public static readonly AutomationProperty LocalizedControlTypeProperty = AutomationElementIdentifiers.LocalizedControlTypeProperty;
		public static readonly AutomationProperty NameProperty = AutomationElementIdentifiers.NameProperty;
		public static readonly AutomationProperty AcceleratorKeyProperty = AutomationElementIdentifiers.AcceleratorKeyProperty;
		public static readonly AutomationProperty AccessKeyProperty = AutomationElementIdentifiers.AccessKeyProperty;
		public static readonly AutomationProperty HasKeyboardFocusProperty = AutomationElementIdentifiers.HasKeyboardFocusProperty;
		public static readonly AutomationProperty IsKeyboardFocusableProperty = AutomationElementIdentifiers.IsKeyboardFocusableProperty;
		public static readonly AutomationProperty IsEnabledProperty = AutomationElementIdentifiers.IsEnabledProperty;
		public static readonly AutomationProperty BoundingRectangleProperty = AutomationElementIdentifiers.BoundingRectangleProperty;
		public static readonly AutomationProperty ProcessIdProperty = AutomationElementIdentifiers.ProcessIdProperty;
		public static readonly AutomationProperty RuntimeIdProperty = AutomationElementIdentifiers.RuntimeIdProperty;
		public static readonly AutomationProperty ClassNameProperty = AutomationElementIdentifiers.ClassNameProperty;
		public static readonly AutomationProperty HelpTextProperty = AutomationElementIdentifiers.HelpTextProperty;
		public static readonly AutomationProperty ClickablePointProperty = AutomationElementIdentifiers.ClickablePointProperty;
		public static readonly AutomationProperty CultureProperty = AutomationElementIdentifiers.CultureProperty;
		public static readonly AutomationProperty IsOffscreenProperty = AutomationElementIdentifiers.IsOffscreenProperty;
		public static readonly AutomationProperty OrientationProperty = AutomationElementIdentifiers.OrientationProperty;
		public static readonly AutomationProperty FrameworkIdProperty = AutomationElementIdentifiers.FrameworkIdProperty;
		public static readonly AutomationProperty IsRequiredForFormProperty = AutomationElementIdentifiers.IsRequiredForFormProperty;
		public static readonly AutomationProperty ItemStatusProperty = AutomationElementIdentifiers.ItemStatusProperty;
		public static readonly AutomationProperty IsDockPatternAvailableProperty = AutomationElementIdentifiers.IsDockPatternAvailableProperty;
		public static readonly AutomationProperty IsExpandCollapsePatternAvailableProperty = AutomationElementIdentifiers.IsExpandCollapsePatternAvailableProperty;
		public static readonly AutomationProperty IsGridItemPatternAvailableProperty = AutomationElementIdentifiers.IsGridItemPatternAvailableProperty;
		public static readonly AutomationProperty IsGridPatternAvailableProperty = AutomationElementIdentifiers.IsGridPatternAvailableProperty;
		public static readonly AutomationProperty IsInvokePatternAvailableProperty = AutomationElementIdentifiers.IsInvokePatternAvailableProperty;
		public static readonly AutomationProperty IsMultipleViewPatternAvailableProperty = AutomationElementIdentifiers.IsMultipleViewPatternAvailableProperty;
		public static readonly AutomationProperty IsRangeValuePatternAvailableProperty = AutomationElementIdentifiers.IsRangeValuePatternAvailableProperty;
		public static readonly AutomationProperty IsSelectionItemPatternAvailableProperty = AutomationElementIdentifiers.IsSelectionItemPatternAvailableProperty;
		public static readonly AutomationProperty IsSelectionPatternAvailableProperty = AutomationElementIdentifiers.IsSelectionPatternAvailableProperty;
		public static readonly AutomationProperty IsScrollPatternAvailableProperty = AutomationElementIdentifiers.IsScrollPatternAvailableProperty;
		public static readonly AutomationProperty IsScrollItemPatternAvailableProperty = AutomationElementIdentifiers.IsScrollItemPatternAvailableProperty;
		public static readonly AutomationProperty IsTablePatternAvailableProperty = AutomationElementIdentifiers.IsTablePatternAvailableProperty;
		public static readonly AutomationProperty IsTableItemPatternAvailableProperty = AutomationElementIdentifiers.IsTableItemPatternAvailableProperty;
		public static readonly AutomationProperty IsTextPatternAvailableProperty = AutomationElementIdentifiers.IsTextPatternAvailableProperty;
		public static readonly AutomationProperty IsTogglePatternAvailableProperty = AutomationElementIdentifiers.IsTogglePatternAvailableProperty;
		public static readonly AutomationProperty IsTransformPatternAvailableProperty = AutomationElementIdentifiers.IsTransformPatternAvailableProperty;
		public static readonly AutomationProperty IsValuePatternAvailableProperty = AutomationElementIdentifiers.IsValuePatternAvailableProperty;
		public static readonly AutomationProperty IsWindowPatternAvailableProperty = AutomationElementIdentifiers.IsWindowPatternAvailableProperty;
		public static readonly AutomationEvent ToolTipOpenedEvent = AutomationElementIdentifiers.ToolTipOpenedEvent;
		public static readonly AutomationEvent ToolTipClosedEvent = AutomationElementIdentifiers.ToolTipClosedEvent;
		public static readonly AutomationEvent StructureChangedEvent = AutomationElementIdentifiers.StructureChangedEvent;
		public static readonly AutomationEvent MenuOpenedEvent = AutomationElementIdentifiers.MenuOpenedEvent;
		public static readonly AutomationEvent AutomationPropertyChangedEvent = AutomationElementIdentifiers.AutomationPropertyChangedEvent;
		public static readonly AutomationEvent AutomationFocusChangedEvent = AutomationElementIdentifiers.AutomationFocusChangedEvent;
		public static readonly AutomationEvent AsyncContentLoadedEvent = AutomationElementIdentifiers.AsyncContentLoadedEvent;
		public static readonly AutomationEvent MenuClosedEvent = AutomationElementIdentifiers.MenuClosedEvent;
		public static readonly AutomationEvent LayoutInvalidatedEvent = AutomationElementIdentifiers.LayoutInvalidatedEvent;
		
		public static IMySuperWrapper RootElement {
			get {
			    switch (_innerElementType) {
			        case InnerElementTypes.AutomationElementNet:
			            return ObjectsFactory.GetMySuperWrapper(AutomationElement.RootElement);
//			        case InnerElementTypes.AutomationElementCom:
//			            //
			        case InnerElementTypes.MySuperWrapper:
			            return RootElement;
			        default:
			            return ObjectsFactory.GetMySuperWrapper(AutomationElement.RootElement);
			    }
			}
		}
		
		public static IMySuperWrapper FocusedElement {
		    get {
		        switch (_innerElementType) {
		            case InnerElementTypes.AutomationElementNet:
		                return ObjectsFactory.GetMySuperWrapper(AutomationElement.FocusedElement);
//		            case InnerElementTypes.AutomationElementCom:
//		                //
		            case InnerElementTypes.MySuperWrapper:
		                return FocusedElement;
		            default:
		                return ObjectsFactory.GetMySuperWrapper(AutomationElement.FocusedElement);
		        }
		    }
		}
		
		public static IMySuperWrapper FromPoint(Point pt)
		{
		    switch (_innerElementType) {
		        case InnerElementTypes.AutomationElementNet:
		            return ObjectsFactory.GetMySuperWrapper(AutomationElement.FromPoint(pt));
//		        case InnerElementTypes.AutomationElementCom:
//		            //
		        case InnerElementTypes.MySuperWrapper:
		            return FromPoint(pt);
		        default:
		            return ObjectsFactory.GetMySuperWrapper(AutomationElement.FromPoint(pt));
		    }
		}
		
		public static IMySuperWrapper FromHandle(IntPtr controlHandle)
		{
		    switch (_innerElementType) {
		        case InnerElementTypes.AutomationElementNet:
		            return ObjectsFactory.GetMySuperWrapper(AutomationElement.FromHandle(controlHandle));
//		        case InnerElementTypes.AutomationElementCom:
//		            //
		        case InnerElementTypes.MySuperWrapper:
		            return FromHandle(controlHandle);
		        default:
		            return ObjectsFactory.GetMySuperWrapper(AutomationElement.FromHandle(controlHandle));
		    }
		}
		
		public AutomationElement GetSourceElement()
		{
		    return _elementHolderNet;
		}
		public void SetSourceElement(AutomationElement element)
		{
		    _elementHolderNet = element;
		}
		
//		public AutomationElement GetSourceElement()
//		{
//		    return this.elementHolderNet;
//		}
//		public void SetSourceElement(AutomationElement element)
//		{
//		    this.elementHolderNet = element;
//		}
		
//		public IMySuperWrapper GetSourceElement()
//		{
//		    return this.elementHolderAdapter;
//		}
//		public void SetSourceElement(IMySuperWrapper element)
//		{
//		    this.elementHolderAdapter = element;
//		}
		
		public string Tag { get; set; }
		
		public void Dispose()
		{
//		    if (InnerElementTypes.AutomationElementNet == innerElementType) { // &&
//		        //null != this.elementHolderNet) {
//		        this.elementHolderNet = null;
//		    }
//		    // this.elementHolderCom = null;
//		    if (InnerElementTypes.MySuperWrapper == innerElementType) { //&&
//		        //null != this.elementHolderAdapter) {
//		        this.elementHolderAdapter = null;
//		    }
//		    this.Cached = null;
//		    this.CachedChildren = null;
//		    this.CachedParent = null;
//		    this.Current = null;
		    
		    // 20131120
		    GC.SuppressFinalize(this);
		}
		
		// internal methods
        public object GetPatternPropertyValue(AutomationProperty property, bool useCache)
        {
        	if (useCache)
        	{
        		//return this.GetCachedPropertyValue(property);
        		switch (_innerElementType) {
        		    case InnerElementTypes.AutomationElementNet:
        		        return _elementHolderNet.GetCachedPropertyValue(property);
        		    //case InnerElementTypes.AutomationElementCom:
        		    //    
        		    case InnerElementTypes.MySuperWrapper:
                        return _elementHolderAdapter.GetCachedPropertyValue(property);
        		    default:
        		        return _elementHolderNet.GetCachedPropertyValue(property);
        		}
        	}
        	//return this.GetCurrentPropertyValue(property);
        	switch (_innerElementType) {
        	    case InnerElementTypes.AutomationElementNet:
        	        return _elementHolderNet.GetCurrentPropertyValue(property);
        	    //case InnerElementTypes.AutomationElementCom:
        	    //    
        	    case InnerElementTypes.MySuperWrapper:
                    return _elementHolderAdapter.GetCurrentPropertyValue(property);
        	    default:
        	        return _elementHolderNet.GetCurrentPropertyValue(property);
        	}
        }
	}
}

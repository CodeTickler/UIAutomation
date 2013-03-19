﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 2/23/2012
 * Time: 11:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System;
    using System.Management.Automation;
    using System.Windows.Automation;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Description of WizardRunCmdletBase.
    /// </summary>
    public class WizardRunCmdletBase : WizardCmdletBase
    {
        public WizardRunCmdletBase()
        {
            Timeout = Preferences.Timeout;
        	this.Automatic = false;
        	this.ForwardDirection = true;
        	
        	// 20130318
        	this.ParametersDictionaries =
        	    new List<Dictionary<string, object>>();
        }
        
        #region Parameters
        [Alias("Milliseconds")]
        [Parameter(Mandatory = false)]
        public int Timeout { get; set; }
        [Parameter(Mandatory = false)]
        public int Seconds {
            get { return Timeout / 1000; } 
            set{ Timeout = value * 1000; }
        }

        [Parameter(Mandatory = false)]
        // 20130318
        //public ScriptBlock[] OnSleepAction { get; set; }
        public new ScriptBlock[] OnSleepAction { get; set; }
        
        [Parameter(Mandatory = false)]
        // 20130318
        //internal new Wizard InputObject { get; set; }
        public new Wizard InputObject { get; set; }
        
        [Parameter(Mandatory = false)]
        public SwitchParameter Automatic { get; set; }
        
        [Parameter(Mandatory = false)]
        public SwitchParameter ForwardDirection { get; set; }
        
        // 20130318
        [Parameter(Mandatory = false)]
        public Hashtable[] Parameters { get; set; }
        #endregion Parameters
        
        internal List<Dictionary<string, object>> ParametersDictionaries { get; set; }
        
		protected internal void RunWizardInAutomaticMode(WizardRunCmdletBase cmdlet, Wizard wizard)
		{
			CurrentData.CurrentWindow = AutomationElement.RootElement;

			while ((null != CurrentData.CurrentWindow)) {

			    if (wizard.StopImmediately) {
			        break;
			    }
			    
				CurrentData.CurrentWindow = null;
				// 20130318
				//cmdlet.RunWizardGetWindowScriptBlocks(cmdlet, wizard);
				cmdlet.RunWizardGetWindowScriptBlocks(cmdlet, wizard, null);
				if (null != (CurrentData.CurrentWindow as AutomationElement)) {
				    
				    cmdlet.WriteVerbose(
				        cmdlet,
				        "the window: name = '" +
				        CurrentData.CurrentWindow.Current.Name +
				        "', automationId = '" +
				        CurrentData.CurrentWindow.Current.AutomationId +
				        "', class = '" +
				        CurrentData.CurrentWindow.Current.ClassName +
				        "', processId = " +
				        CurrentData.CurrentWindow.Current.ProcessId.ToString() +
				        ".");
				    
    				// selector of steps' unique controls
    				WizardStep currentStep =
    					wizard.GetActiveStep();

    				if (null != currentStep) {
        
                        cmdlet.WriteVerbose(
                            cmdlet,
                            "current ste name = " +
                            currentStep.Name);
                        
    				    // 20130318
    					//cmdlet.RunWizardStepScriptBlocks(cmdlet, currentStep, cmdlet.ForwardDirection);
    					cmdlet.RunWizardStepForwardOrBackwardScriptBlocks(
    					    cmdlet,
    					    currentStep,
    					    cmdlet.ForwardDirection,
    					    cmdlet.ForwardDirection ? currentStep.StepForwardActionParameters : currentStep.StepBackwardActionParameters);

    					// 20130319 - need moving to an appropriate place
    					//cmdlet.RunWizardStepCancelScriptBlocks(
    					//    cmdlet,
    					//    currentStep,
    					//    currentStep.StepCancelActionParameters);
                    } else {
                        
                        cmdlet.WriteVerbose(
                            cmdlet,
                            "current step is still null");
                    }
				} else {
				    
				    cmdlet.WriteVerbose(
				        cmdlet,
				        "window is still null");
				}
			}
		}
    }
}

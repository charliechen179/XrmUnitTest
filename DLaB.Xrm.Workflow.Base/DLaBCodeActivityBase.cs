﻿using System;
using System.Activities;
using System.ServiceModel;
#if DLAB_UNROOT_NAMESPACE || DLAB_XRM
using DLaB.Xrm.Plugin;
#else
using Source.DLaB.Xrm.Plugin;
#endif
using Microsoft.Xrm.Sdk;

#if DLAB_UNROOT_NAMESPACE || DLAB_XRM_WORKFLOW
namespace DLaB.Xrm.Workflow
#else
namespace Source.DLaB.Xrm.Workflow
#endif
{
    public abstract class DLaBCodeActivityBase : CodeActivity
    {
        protected override void Execute(CodeActivityContext codeActivityContext)
        {
            PreExecute(codeActivityContext);

            if (codeActivityContext == null)
            {
                throw new InvalidPluginExecutionException("codeActivityContext");
            }

            // Construct the local plug-in context.
            var context = new DLaBExtendedWorkflowContext(codeActivityContext, this);

            try
            {
                using (context.TraceTime("{0}.Execute()", context.CodeActivityTypeName))
                {
                    // Invoke the custom implementation 
                    Execute(context);
                }   
            }
            catch (Exception e)
            {
                if(ExecuteExceptionHandler(e, context))
                {
                    throw;
                }
            }
            finally
            {
                PostExecute(context);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public abstract void Execute(IExtendedWorkflowContext context);

        /// <summary>
        /// Method that gets called when an exception occurs in the Execute method.  Return true if the exception should be rethrown.
        /// This prevents losing the stack trace by rethrowing the originally caught error.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        protected virtual bool ExecuteExceptionHandler(Exception ex, IExtendedWorkflowContext context)
        { 
            context.LogException(ex);
            // Unexpected Exception occurred, log exception then wrap and throw new exception
            if (context.IsolationMode == (int)IsolationMode.Sandbox)
            {
                Sandbox.ExceptionHandler.AssertCanThrow(ex);
            }
            return true;
        }

        /// <summary>
        /// Method that gets called before the Execute
        /// </summary>
        /// <param name="codeActivityContext"></param>
        protected virtual void PreExecute(CodeActivityContext codeActivityContext) { }

        /// <summary>
        /// Method that gets called after the Execute
        /// </summary>
        /// <param name="codeActivityContext"></param>
        protected virtual void PostExecute(DLaBExtendedWorkflowContext context) { }
    }
}
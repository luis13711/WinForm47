﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1366
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WebLogAnalyzer.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Web Log Analyzer.
        '''</summary>
        Friend ReadOnly Property AppName() As String
            Get
                Return ResourceManager.GetString("AppName", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property background() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Internal Server Error (500).
        '''</summary>
        Friend ReadOnly Property HttpCodeInternalServerError() As String
            Get
                Return ResourceManager.GetString("HttpCodeInternalServerError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Not Found (404).
        '''</summary>
        Friend ReadOnly Property HttpCodeNotFound() As String
            Get
                Return ResourceManager.GetString("HttpCodeNotFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Not Modified (304).
        '''</summary>
        Friend ReadOnly Property HttpCodeNotModified() As String
            Get
                Return ResourceManager.GetString("HttpCodeNotModified", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Other.
        '''</summary>
        Friend ReadOnly Property HttpCodeOther() As String
            Get
                Return ResourceManager.GetString("HttpCodeOther", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Succeeded (200).
        '''</summary>
        Friend ReadOnly Property HttpCodeSucceeded() As String
            Get
                Return ResourceManager.GetString("HttpCodeSucceeded", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unauthorized (401).
        '''</summary>
        Friend ReadOnly Property HttpCodeUnauthorized() As String
            Get
                Return ResourceManager.GetString("HttpCodeUnauthorized", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid date directive..
        '''</summary>
        Friend ReadOnly Property InvalidDateDirective() As String
            Get
                Return ResourceManager.GetString("InvalidDateDirective", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid date or time found in {0}..
        '''</summary>
        Friend ReadOnly Property InvalidDateOrTime() As String
            Get
                Return ResourceManager.GetString("InvalidDateOrTime", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid fields directive in {0}..
        '''</summary>
        Friend ReadOnly Property InvalidFieldsDirective() As String
            Get
                Return ResourceManager.GetString("InvalidFieldsDirective", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid log entry found in {0}..
        '''</summary>
        Friend ReadOnly Property InvalidLogEntry() As String
            Get
                Return ResourceManager.GetString("InvalidLogEntry", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid log file: {0}..
        '''</summary>
        Friend ReadOnly Property InvalidLogFile() As String
            Get
                Return ResourceManager.GetString("InvalidLogFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Invalid status value in {0}..
        '''</summary>
        Friend ReadOnly Property InvalidStatusValue() As String
            Get
                Return ResourceManager.GetString("InvalidStatusValue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Failed to determine access time in {0}..
        '''</summary>
        Friend ReadOnly Property MissingAccessTime() As String
            Get
                Return ResourceManager.GetString("MissingAccessTime", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Log file does not contain cs-uri-stem field..
        '''</summary>
        Friend ReadOnly Property MissingUriStem() As String
            Get
                Return ResourceManager.GetString("MissingUriStem", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to No log files found in {0}..
        '''</summary>
        Friend ReadOnly Property NoLogFiles() As String
            Get
                Return ResourceManager.GetString("NoLogFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Web Log Analysis.
        '''</summary>
        Friend ReadOnly Property ReportDisplayName() As String
            Get
                Return ResourceManager.GetString("ReportDisplayName", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
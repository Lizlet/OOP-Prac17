﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("OOP_Prac17.Resources", GetType(Resources).Assembly)
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
        '''  Looks up a localized string similar to drop table if exists post_numbers;drop table if exists post_locations;create table post_locations (locationID int primary key,locationName varchar(25)) engine = innodb;create table post_numbers (postNumber char(5) primary key,locationID int,foreign key (locationID) references post_locations(locationID) on update cascade on delete restrict) engine = innodb;.
        '''</summary>
        Friend ReadOnly Property createTables() As String
            Get
                Return ResourceManager.GetString("createTables", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sondg.
        '''</summary>
        Friend ReadOnly Property dbn() As String
            Get
                Return ResourceManager.GetString("dbn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 0001	OSLO	0301	OSLO	P
        '''0010	OSLO	0301	OSLO	B
        '''0015	OSLO	0301	OSLO	B
        '''0018	OSLO	0301	OSLO	G
        '''0021	OSLO	0301	OSLO	P
        '''0024	OSLO	0301	OSLO	P
        '''0025	OSLO	0301	OSLO	P
        '''0026	OSLO	0301	OSLO	B
        '''0028	OSLO	0301	OSLO	P
        '''0030	OSLO	0301	OSLO	P
        '''0031	OSLO	0301	OSLO	P
        '''0032	OSLO	0301	OSLO	P
        '''0033	OSLO	0301	OSLO	P
        '''0034	OSLO	0301	OSLO	P
        '''0037	OSLO	0301	OSLO	F
        '''0040	OSLO	0301	OSLO	S
        '''0045	OSLO	0301	OSLO	G
        '''0046	OSLO	0301	OSLO	S
        '''0047	OSLO	0301	OSLO	S
        '''0048	OSLO	0301	OSLO	P
        '''0050	OSLO	0301	OSLO	G
        '''0051	OSLO	0301	OSLO	P
        '''0055	O [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Postnummerregister_ansi() As String
            Get
                Return ResourceManager.GetString("Postnummerregister_ansi", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 7ppasexr.
        '''</summary>
        Friend ReadOnly Property pwd() As String
            Get
                Return ResourceManager.GetString("pwd", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to select postNumber as &quot;post number&quot;, locationName as &quot;location name&quot; from post_numbers pn, post_locations pl where pn.locationID = pl.locationID and pl.locationName like @locationName.
        '''</summary>
        Friend ReadOnly Property searchQuery() As String
            Get
                Return ResourceManager.GetString("searchQuery", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to mysql.stud.iie.ntnu.no.
        '''</summary>
        Friend ReadOnly Property server() As String
            Get
                Return ResourceManager.GetString("server", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to sondg.
        '''</summary>
        Friend ReadOnly Property uid() As String
            Get
                Return ResourceManager.GetString("uid", resourceCulture)
            End Get
        End Property
    End Module
End Namespace

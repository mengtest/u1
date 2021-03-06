﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GRichTextFieldWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GRichTextField), typeof(FairyGUI.GTextField));
		L.RegFunction("GetHtmlObject", GetHtmlObject);
		L.RegFunction("GetHtmlObjectAt", GetHtmlObjectAt);
		L.RegFunction("New", _CreateFairyGUI_GRichTextField);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("htmlObjectCount", get_htmlObjectCount, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GRichTextField(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GRichTextField obj = new FairyGUI.GRichTextField();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GRichTextField.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHtmlObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRichTextField));
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.Utils.IHtmlObject o = obj.GetHtmlObject(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHtmlObjectAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)ToLua.CheckObject(L, 1, typeof(FairyGUI.GRichTextField));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.Utils.IHtmlObject o = obj.GetHtmlObjectAt(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_htmlObjectCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			int ret = obj.htmlObjectCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index htmlObjectCount on a nil value" : e.Message);
		}
	}
}


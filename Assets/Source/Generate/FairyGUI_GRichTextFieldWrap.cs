﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GRichTextFieldWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GRichTextField), typeof(FairyGUI.GTextField));
		L.RegFunction("GetHtmlObject", GetHtmlObject);
		L.RegFunction("New", _CreateFairyGUI_GRichTextField);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("text", get_text, set_text);
		L.RegVar("displayAsPassword", get_displayAsPassword, set_displayAsPassword);
		L.RegVar("align", get_align, set_align);
		L.RegVar("singleLine", get_singleLine, set_singleLine);
		L.RegVar("stroke", get_stroke, set_stroke);
		L.RegVar("strokeColor", get_strokeColor, set_strokeColor);
		L.RegVar("shadowOffset", get_shadowOffset, set_shadowOffset);
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
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			string ret = obj.text;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index text on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_displayAsPassword(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			bool ret = obj.displayAsPassword;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index displayAsPassword on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_align(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			FairyGUI.AlignType ret = obj.align;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index align on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_singleLine(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			bool ret = obj.singleLine;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index singleLine on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stroke(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			int ret = obj.stroke;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index stroke on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_strokeColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			UnityEngine.Color ret = obj.strokeColor;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index strokeColor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shadowOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			UnityEngine.Vector2 ret = obj.shadowOffset;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index shadowOffset on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.text = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index text on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_displayAsPassword(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.displayAsPassword = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index displayAsPassword on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_align(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			FairyGUI.AlignType arg0 = (FairyGUI.AlignType)ToLua.CheckObject(L, 2, typeof(FairyGUI.AlignType));
			obj.align = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index align on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_singleLine(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.singleLine = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index singleLine on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stroke(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.stroke = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index stroke on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_strokeColor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.strokeColor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index strokeColor on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shadowOffset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GRichTextField obj = (FairyGUI.GRichTextField)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.shadowOffset = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index shadowOffset on a nil value" : e.Message);
		}
	}
}


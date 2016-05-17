﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Experimental_Director_DirectorPlayerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Experimental.Director.DirectorPlayer), typeof(UnityEngine.Behaviour));
		L.RegFunction("Play", Play);
		L.RegFunction("Stop", Stop);
		L.RegFunction("SetTime", SetTime);
		L.RegFunction("GetTime", GetTime);
		L.RegFunction("SetTimeUpdateMode", SetTimeUpdateMode);
		L.RegFunction("GetTimeUpdateMode", GetTimeUpdateMode);
		L.RegFunction("New", _CreateUnityEngine_Experimental_Director_DirectorPlayer);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Experimental_Director_DirectorPlayer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Experimental.Director.DirectorPlayer obj = new UnityEngine.Experimental.Director.DirectorPlayer();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Experimental.Director.DirectorPlayer.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer), typeof(UnityEngine.Experimental.Director.Playable)))
			{
				UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.ToObject(L, 1);
				UnityEngine.Experimental.Director.Playable arg0 = (UnityEngine.Experimental.Director.Playable)ToLua.ToObject(L, 2);
				obj.Play(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer), typeof(UnityEngine.Experimental.Director.Playable), typeof(object)))
			{
				UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.ToObject(L, 1);
				UnityEngine.Experimental.Director.Playable arg0 = (UnityEngine.Experimental.Director.Playable)ToLua.ToObject(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.Play(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Experimental.Director.DirectorPlayer.Play");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer));
			obj.Stop();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer));
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			obj.SetTime(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer));
			double o = obj.GetTime();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTimeUpdateMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer));
			UnityEngine.Experimental.Director.DirectorUpdateMode arg0 = (UnityEngine.Experimental.Director.DirectorUpdateMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.Experimental.Director.DirectorUpdateMode));
			obj.SetTimeUpdateMode(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTimeUpdateMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Experimental.Director.DirectorPlayer obj = (UnityEngine.Experimental.Director.DirectorPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.Experimental.Director.DirectorPlayer));
			UnityEngine.Experimental.Director.DirectorUpdateMode o = obj.GetTimeUpdateMode();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
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
}


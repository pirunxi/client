﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DownloadManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DownloadManager), typeof(System.Object));
		L.RegFunction("Init", Init);
		L.RegFunction("Reset", Reset);
		L.RegFunction("Update", Update);
		L.RegFunction("createTask", createTask);
		L.RegFunction("UpdatePriority", UpdatePriority);
		L.RegFunction("waitAllDownload", waitAllDownload);
		L.RegFunction("New", _CreateDownloadManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Ins", get_Ins, null);
		L.RegVar("MaxDownloadingTaskNum", null, set_MaxDownloadingTaskNum);
		L.RegVar("DownloadingBytes", get_DownloadingBytes, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateDownloadManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				DownloadManager obj = new DownloadManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: DownloadManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
			DownloadManager.Config arg0 = (DownloadManager.Config)ToLua.CheckObject<DownloadManager.Config>(L, 2);
			obj.Init(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Reset(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
			obj.Update();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int createTask(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
				System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<string>));
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				string arg3 = ToLua.CheckString(L, 5);
				DownloadManager.Task o = obj.createTask(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 6)
			{
				DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
				System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<string>));
				string arg1 = ToLua.CheckString(L, 3);
				string arg2 = ToLua.CheckString(L, 4);
				string arg3 = ToLua.CheckString(L, 5);
				int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
				DownloadManager.Task o = obj.createTask(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DownloadManager.createTask");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdatePriority(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
			DownloadManager.Task arg0 = (DownloadManager.Task)ToLua.CheckObject<DownloadManager.Task>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.UpdatePriority(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int waitAllDownload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DownloadManager obj = (DownloadManager)ToLua.CheckObject<DownloadManager>(L, 1);
			System.Collections.IEnumerator o = obj.waitAllDownload();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Ins(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, DownloadManager.Ins);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DownloadingBytes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DownloadManager obj = (DownloadManager)o;
			long ret = obj.DownloadingBytes;
			LuaDLL.tolua_pushint64(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DownloadingBytes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MaxDownloadingTaskNum(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DownloadManager obj = (DownloadManager)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.MaxDownloadingTaskNum = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MaxDownloadingTaskNum on a nil value");
		}
	}
}

#include <iostream>
#include <vector>
#include <string>

#ifdef __cplusplus
extern "C" {
#endif

#include "lua.h"
#include "lualib.h"
#include "lauxlib.h"

#ifdef __cplusplus
}
#endif

int add(lua_State *L)
{
    double a = lua_tonumber(L, 1);
    double b = lua_tonumber(L, 2);
    lua_pushnumber(L, a + b);
    return 1;
}

int luaLog(lua_State* L)
{
    std::string tt = lua_tostring(L, -1);
    int tt2 = lua_tointeger(L, -2);
    //std::string tt2 = lua_tostring(L, -2);
    printf("HEHEHEHE %s\n", tt.c_str());
    printf("HEHE %d\n", tt2);
    //printf("HEHEHEHE %s\n", tt2.c_str());
    return 1;
}

int main()
{
    std::string str = "testStr";
    printf("%s", str.c_str());

    lua_State* L = lua_open();
    luaL_openlibs(L);
    const luaL_reg global_functions[] =
    {
        {"MyLog", luaLog},
        {nullptr, nullptr}
    };
    luaL_register(L, "_G", global_functions);

    luaL_dofile(L, "test.lua");

    lua_close(L);
}
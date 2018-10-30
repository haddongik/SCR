print("hello")

local function TestFunc(val1)
    val1 = val1 + 10
    return val1
end

print(TestFunc(10))

-- 루아 테이블 관련 처리 테스트
local source = { 10, 20, 30 }
for k,v in pairs(source) do
    print(k .. ' ' .. v)
end

local srcStr = 'haddongik'
local desStr = string.gmatch( srcStr, '[0-9]+' )
print(desStr)
--Test2Func()


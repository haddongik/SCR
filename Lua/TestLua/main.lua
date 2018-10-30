local a = function(f1, f2, f3)

end

obj = {}
obj.items = {}

table.insert( obj.items,  { type = 'A', itemid = 52342, count = 10})
table.insert( obj.items,  { type = 'C', itemid = 52342, count = 20})
table.insert( obj.items,  { type = 'C', itemid = 52342, count = 0})
table.insert( obj.items,  { type = 'A', itemid = 52342, count = 10})
table.insert( obj.items,  { type = 'A', itemid = 52342, count = 10})
table.insert( obj.items,  { type = 'D', itemid = 52342, count = 30})
table.insert( obj.items,  { type = 'A', itemid = 52342, count = 40})

filters = {}
filters['A'] = function(v) return v.type == 'A' and v.count > 0 end
filters['B'] = function(v) return v.type == 'B' end
filters['C'] = function(v) return v.type == 'C' end
filters['All'] = function(v) return (fliters['A'](v) or fliters['B'](v) or fliters['C'](v)) end

tab = 'C'
for i,v in pairs(obj.items) do
    if filters[tab](v) then
        print(v.type)
    end
end

tA = {10,20,30,40,55}
for id=1, #tA do
    print(tA[id])
end

tB = {one = 10, two = 30}
for i,v in pairs(tB) do
    print(i)
    print(v)
end

parentClass = { parentVal1 = 0, parentVal2 = 1 }

function parentClass:new()

end
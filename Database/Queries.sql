select a.ItemId, a.ItemDescription, a.TypeId, b.TypeDescription, a.StatusId, c.StatusDescription, a.ChangeDate
from dbo.Item a 
inner join dbo.[Type] b on a.TypeId = b.TypeId
inner join dbo.[Status] c on a.StatusId = c.StatusId
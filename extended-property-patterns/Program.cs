const string rawGuid = "21F67400-4C18-4B57-9DE3-2EF7FB5D2B09";

var entityId = new EntityId(rawGuid);
var entity = new Entity(entityId);

if (entity is { Id.Value: rawGuid })
{
    Console.WriteLine("Has same guid");
}



entity = null;
if (entity is not { Id.Value: rawGuid })
{
    Console.WriteLine("Not the same guid anymore");
}

internal record Entity(EntityId Id);
internal record EntityId(string Value);

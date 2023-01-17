var entityId = new EntityId(Guid.NewGuid());

var entity1 = new Entity(entityId);
var entity2 = new Entity(entityId);

Console.WriteLine(entity1);
Console.WriteLine(entity1 == entity2);

//entity2.Id = new EntityId(Guid.NewGuid());
entity2 = entity2 with{ Id = new EntityId(Guid.NewGuid()) };
Console.WriteLine(entity1 == entity2);


internal record Entity(EntityId Id);
internal record EntityId(Guid Value);
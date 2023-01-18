// language=json
var json = """
{
    "headers": [
      { "name": "Authorization", "value": "Bearer xxxxxxxxxxxxxxxxx" }
    ],
    "body": ""
}
""";

Console.WriteLine(json);

var id = 1;
// language=xml
var xml = $$"""
<Root>
    <Entities>
        <Entity>
            <Field name="id" value="{{id}}" />
        </Entity>
    </Entities>
</Root>
""";

Console.WriteLine(xml);


var source = new Source();
source.Print();

var source2 = new InheritedSource();
source2.Print();

var source3 = new FileSource();
source3.Print();


class FileSource : Source
{
    // Compile error
    // protected override private int Value => 6;
}
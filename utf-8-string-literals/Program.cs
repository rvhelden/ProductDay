
using System.Text;

ReadOnlySpan<byte> utf8 = "123"u8;
ReadOnlySpan<byte> utf16 = Encoding.Unicode.GetBytes("123");

Console.WriteLine(string.Join(" ", utf8.ToArray().Select(x => $"0x{x}")));
Console.WriteLine(string.Join(" ", utf16.ToArray().Select(x => $"0x{x}")));

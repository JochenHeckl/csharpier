class ClassName
{
    [DllImport("kernel32", SetLastError = true)]
    static extern bool CreateDirectory(string name, SecurityAttribute sa);
}
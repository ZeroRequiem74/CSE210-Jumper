class Parachute
{
    public int Lines(int cutLines)
    {
        int lines = 4;
        lines -= cutLines;
        return lines;
    }
}
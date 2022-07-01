using System.Collections;

namespace Slot8;
public class IntCollection
{
    private ArrayList arInts = new ArrayList();
    public int GetInt(int pos) => (int)arInts[pos];
    public int AddInt(int n) => arInts.Add(n);
    public void ClearInt() => arInts.Clear();
    public int Count() => arInts.Count;
}
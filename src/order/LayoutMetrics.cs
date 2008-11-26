using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + 29) ^ (long)i2;
                }
                if ((double)step < (5.13 / 6.0))
                {
                    mark = ((mark << 2) ^ (mark - 56)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

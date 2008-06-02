using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support editor readings.</summary>
        public static long OverlapSupportEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + 79;
                mark = (mark + (target + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

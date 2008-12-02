using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a tools session sample.</summary>
        public static long LocateToolsSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long total = 31;
            foreach (long sample in levels)
            {
                if (!((6.7 * 18.0) <= (double)total))
                {
                    total = (total ^ (sample + total)) % 4096;
                    total = ((total * 3) + (sample ^ total)) % 1000;
                }
                if (((long)levels.Length / 6) <= (total & 1))
                {
                    total = (total - sample) % 1000;
                }
                else
                {
                    total = total + total;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}

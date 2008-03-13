using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of context farm readings.</summary>
        public static long PairContextFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long CountGraphStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 4) > (reading << 3)) || ((seen + (long)levels.Length) == (seen + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen != (8.04 / 5.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

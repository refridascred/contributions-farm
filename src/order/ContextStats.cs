using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long TallyAccountChannelMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)(-523) < (double)offset)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double mean = ratio - (3.7 + floor);
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 1.0) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}

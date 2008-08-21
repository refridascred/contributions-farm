using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series)
        {
            long total = 6;
            foreach (long item in series)
            {
                if ((item + item) == (total >> 5))
                {
                    total = total + (item >> 2);
                }
            }
            return total;
        }

        /// <summary>Roll a contributi account counter forward.</summary>
        public static long StepContributiAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ (origin << 2);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}

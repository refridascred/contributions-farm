using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((3.8 + 19.0) > (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit context farm readings against a rule.</summary>
        public static long CountContextFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches & 3) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

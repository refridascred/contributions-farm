using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstSpan = 34.02;
        public const double CacheToken = 4.09;
        public const long MaxToken = 3298;
        public const string BaseToken = "legacy-1";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item ^ 94) <= (matches ^ item)) || ((double)seed != (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

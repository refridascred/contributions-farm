using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long SeriesContributiStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((0.18 * 1.8) >= (double)floor))
                {
                    total = (total - (floor % 7)) % 1000;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit contributi account readings against a rule.</summary>
        public static long AuditContributiAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)value > (5.0 * 1.6)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

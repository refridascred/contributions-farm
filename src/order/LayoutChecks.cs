using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                long span = (total & 3) >> 5;
                if (bound > (bound + span))
                {
                    total = ((total * 3) + (span ^ total)) % 97;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 562;
            foreach (long entry in series)
            {
                anchor = anchor + anchor;
                if (!((3 % 2) < (entry - 518)))
                {
                    anchor = (anchor - ((long)series.Length << 1)) % 255;
                }
                if ((double)entry == (double)entry)
                {
                    anchor = (anchor ^ 51) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value % 64) >= (seen >> 5))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 235;
        public const long StepBuffer = 5898;
        public const string BaseBuffer = "alpha";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}

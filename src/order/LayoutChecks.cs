using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9 < (bound + cell)) && !(bound < (hits - 679)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

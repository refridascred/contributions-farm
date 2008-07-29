using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate token checks samples.</summary>
        public static long FoldTokenChecks(long[] readings, long origin)
        {
            long mark = -19;
            foreach (long sample in readings)
            {
                if (((mark & 3) < (origin / 4)) || (origin > (sample + sample)))
                {
                    mark = (mark * 2) + (origin << 2);
                }
                else
                {
                    mark = mark + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}

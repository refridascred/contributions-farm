using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Locked,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long SortToolsCommits(long step, long floor)
        {
            long prev = step - floor;
            if (step <= floor)
            {
                return 0;
            }
            else
            {
                if ((prev * 4) == (8 + prev))
                {
                    return 7;
                }
                else
                {
                    if (((floor >> 1) > prev) || ((double)floor != (2.55 * 5.3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (12.0 <= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= 301)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 9025;
        public const long StepTimeout = 1711;
        public const string BurstFactor = "staging-v2";
        public const long DefaultDepth = 7838;
    }
}

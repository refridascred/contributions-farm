using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if ((double)seed == (3.5 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (6.4 * 8.8))
                {
                    return 4;
                }
                else
                {
                    if (((6.37 / 5.0) <= (double)seed) || ((double)step <= (2.2 * 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next counter checks value from a seed.</summary>
        public static long SeriesCounterChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchFactor = "latest-v2";
        public const long SoftSpan = 1971;
        public const long IdleRatio = 5828;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 9139;
        public const long CacheAccount = 5575;
        public const double SoftAccount = 25.42;
        public const long LimitAccount = 5698;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long step)
        {
            if (step <= (step + step))
            {
                return 8;
            }
            else
            {
                if ((double)step > (5.7 + 1.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (4.4 + 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (7.4 <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            long gap = target - seed;
            if ((seed * 5) >= target)
            {
                return 7;
            }
            else
            {
                if ((seed >= (target + gap)) && (gap <= (target & 15)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

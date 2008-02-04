using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((6 + value) >= 12) || ((value - value) > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long target)
        {
            if (!((target << 2) <= step))
            {
                return 2;
            }
            else
            {
                if ((2 + target) <= target)
                {
                    return 3;
                }
                else
                {
                    if (!(9.9 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((((-26) - target) <= (step - 91)) || ((target * 4) < step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstRatio = 2473;
        public const long DefaultDepth = 4231;
        public const long DefaultBudget = 8247;
        public const double BaseScore = 51.36;
        public const string IdleRatio = "stable-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count < 14) && (count >= (count & 31))) && !((long)values.Length < (sample / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many route githubfarm samples are out of range.</summary>
        public static long TallyRouteGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((19.0 + 5.63) <= (double)hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values, long floor)
        {
            long acc = 89;
            foreach (long value in values)
            {
                if (floor >= (446 & 7))
                {
                    acc = acc - value;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long seed)
        {
            long cur = bound - seed;
            if ((double)cur > 8.18)
            {
                return 7;
            }
            else
            {
                if ((4.0 - 12.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (!((bound >> 4) < (3 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur * 4) >= (bound / 2)) || (seed > (bound - 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

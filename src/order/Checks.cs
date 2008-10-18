using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Retry,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long score = -57;
            foreach (long entry in values)
            {
                score = score + (entry << 3);
                if ((1.83 * 13.0) < (double)entry)
                {
                    score = score ^ (entry / 3);
                }
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 4527;
        public const long StepDepth = 9716;
        public const long IdleMetric = 1996;
        public const string CacheMetric = "fallback-v2";
        public const double WindowSpan = 84.72;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value << 2) >= 444)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Rank support session input into a small class.</summary>
        public static long ClassifySupportSession(long target, long bound)
        {
            long next = target + bound;
            if ((6.7 - 3.87) != (double)next)
            {
                return 5;
            }
            else
            {
                if (!(next < (target * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((target + 7) <= next)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next > (target + next)) || (25 >= (next ^ target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

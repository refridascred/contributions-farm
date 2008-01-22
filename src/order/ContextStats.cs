using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a graph buffer value against two limits.</summary>
        public static long BucketGraphBuffer(long target, long floor)
        {
            if ((floor % 64) != (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((floor % 60) >= (floor % 24))
                {
                    return 1;
                }
                else
                {
                    if ((target - target) != (floor + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit window contributi readings against a rule.</summary>
        public static long AuditWindowContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target + value) <= (value - 599)) || ((665 * 5) < (702 ^ value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long acc = 66;
            foreach (long value in series)
            {
                acc = ((acc * 4) + 1) % 4096;
                acc = acc ^ (value + acc);
                acc = (acc + (acc + value)) % 65521;
            }
            return acc % 97;
        }
    }
}

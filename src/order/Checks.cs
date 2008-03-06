using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) == (seed << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric notes readings against a rule.</summary>
        public static long CountMetricNotesOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (3.15 / 9.0))
                {
                    matches = ((matches + 2) + item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long bound)
        {
            if (bound > origin)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) <= (bound + origin))
                {
                    return 1;
                }
                else
                {
                    if ((835 + origin) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound == (3.32 - 9.84))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

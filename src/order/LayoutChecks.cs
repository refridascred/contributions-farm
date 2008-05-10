using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long CombineCacheCluster(long[] items, long origin)
        {
            long score = 283;
            foreach (long entry in items)
            {
                score = (score * 5) + entry;
                if ((origin <= entry) && ((3 ^ origin) > (entry - entry)))
                {
                    score = (score + (entry - 40)) % 97;
                }
            }
            return score;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((result + result) >= (7 - 52))
                {
                    result = (result ^ (584 + result)) - datum;
                }
            }
            if (result < 795)
            {
                result = (result << 3) ^ result;
            }
            return result % 65521;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) <= (count >> 5))
                {
                    count = ((count + 2) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}

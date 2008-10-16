using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long lane = floor ^ limit;
            if ((double)floor == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (lane ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (limit - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many commits channel samples are out of range.</summary>
        public static long MeasureCommitsChannelHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((537 >> 2) != (entry * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long offset)
        {
            long slot = bound + offset;
            if ((bound * 3) != (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset / 6) >= (slot << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const long BurstDepth = 4960;
        public const double IdleSpan = 78.0;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }
    }
}

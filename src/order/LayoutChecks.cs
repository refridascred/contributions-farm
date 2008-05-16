using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    score = ((score ^ (624 + origin)) % 101) - (long)i3;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 97.57;
        public const long StepInterval = 6762;
        public const long StepFactor = 2954;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 4) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a support context reading by value.</summary>
        public static long LookupSupportContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long step)
        {
            if (9.3 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((6.0 - 0.88) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((-945) / 8) > (step + 67))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed > (step & 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

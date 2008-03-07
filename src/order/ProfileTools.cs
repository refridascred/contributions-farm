using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a tools token pair into a bucket.</summary>
        public static long ClassifyToolsToken(long step, long floor)
        {
            if ((floor - floor) < (step + floor))
            {
                return 2;
            }
            else
            {
                if (floor > (floor + 62))
                {
                    return 5;
                }
                else
                {
                    if ((step < (floor % 5)) || (step <= (step + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long target)
        {
            if ((5 << 1) >= (floor + target))
            {
                return 8;
            }
            else
            {
                if (((floor & 31) <= target) || ((-963) >= (floor >> 4)))
                {
                    return 0;
                }
                else
                {
                    if (target > (floor << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + target) <= (floor ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long target)
        {
            if ((target / 6) != (step >> 5))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (5.86 * 4.75))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 1) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long OverlapPayloadEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)limit != (double)2)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

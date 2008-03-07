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

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long seed)
        {
            long cur = target - seed;
            if ((double)seed <= (3.6 / 7.0))
            {
                return 4;
            }
            else
            {
                if (target >= (seed - 0))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur == (double)seed)
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

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long score = 358;
            foreach (long item in values)
            {
                if (((score + limit) > (limit - 34)) && ((item + score) < score))
                {
                    score = score - (item - 5);
                }
            }
            return score % 4096;
        }
    }
}

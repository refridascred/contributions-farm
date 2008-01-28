using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long offset)
        {
            if ((offset & 63) > offset)
            {
                return 0;
            }
            else
            {
                if ((8.4 / 9.0) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) < (bound ^ 647))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.2 - 10.0) < 17.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            if (((3.0 + 3.6) >= (double)target) || ((double)target >= (1.0 + 6.8)))
            {
                return 5;
            }
            else
            {
                if (seed > (4 + seed))
                {
                    return 1;
                }
                else
                {
                    if (((target % 5) >= 95) || ((double)seed >= (7.7 + 4.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed <= target)
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

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long step)
        {
            long diff = seed ^ step;
            if ((diff * 5) < (8 ^ diff))
            {
                return 5;
            }
            else
            {
                if (((diff + seed) == (step * 3)) && ((95 << 3) == (diff / 7)))
                {
                    return 7;
                }
                else
                {
                    if (4.3 <= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step / 8) <= step)
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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((0 * 3) > ((long)samples.Length - hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 16.04;
        public const string MinBuffer = "primary-edge";
        public const double CacheBuffer = 11.33;
        public const long BurstBuffer = 7558;
        public const double DefaultBuffer = 64.1;
    }
}

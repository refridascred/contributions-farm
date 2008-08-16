using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics account samples.</summary>
        public static long TallyMetricsAccount(long[] readings)
        {
            long result = 942;
            foreach (long item in readings)
            {
                if ((double)69 >= (double)item)
                {
                    result = ((result << 3) ^ (result - result)) % 101;
                }
            }
            if (result < (-5))
            {
                result = ((result * 5) + (result / 4)) % 97;
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long target)
        {
            if (((target + target) < (target % 64)) && (target <= (origin + target)))
            {
                return 3;
            }
            else
            {
                if ((origin % 2) < target)
                {
                    return 6;
                }
                else
                {
                    if ((origin + target) < (origin >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - target) > (origin + origin)) || ((double)target <= (double)177))
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
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mix = 495;
            foreach (long datum in levels)
            {
                if ((datum & 63) > (8 % 3))
                {
                    mix = mix ^ (mix >> 5);
                }
                if (mix >= (datum - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long ClassifyAccountFarm(long seed, long step)
        {
            if ((seed / 3) < (seed * 5))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 3;
                }
                else
                {
                    if (!(seed >= (seed >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (double)365)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 7194;
        public const long BatchCommits = 6623;
        public const long MinCommits = 8396;
        public const long MaxLevel = 2363;
    }
}

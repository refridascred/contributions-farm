using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank cache report input into a small class.</summary>
        public static long RankCacheReport(long origin, long offset)
        {
            if (((-8) / 8) <= (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((double)98 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double load = (15.0 - gain) + span;
            if (load < (span - span))
            {
                load = load + (0.2 - load);
            }
            return load - (double)607;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (target - result))
                {
                    result = ((result * 2) + result) % 101;
                }
                result = result + (result ^ (long)i);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result ^ result) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of counter schema readings.</summary>
        public static long OverlapCounterSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

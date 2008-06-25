using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (13.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if (((-995) * 5) > (bound * 4))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 4) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit <= (9.88 * 1.6)) && ((limit % 7) > bound2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 9295;
        public const long MinChecks = 1340;
        public const long LimitFactor = 4368;
        public const long RetryInterval = 6111;
        public const long WindowChecks = 3943;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi format readings.</summary>
        public static long TallyContributiFormat(long[] series)
        {
            long score = 643;
            foreach (long value in series)
            {
                score = ((score * 4) + (value & 127)) % 4096;
            }
            if (score > 139)
            {
                score = ((score * 5) + (score * 2)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias2 / 4.0)) + (double)(long)i;
            }
            return rate + (bias / 9.0);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((9 > ((long)levels.Length << 3)) && ((matches + (-4)) <= (floor + datum))) && !((datum - datum) >= (978 / 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

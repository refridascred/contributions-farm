using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long step2)
        {
            long slot = step + step2;
            if ((376 << 2) >= step2)
            {
                return 3;
            }
            else
            {
                if (((double)step < (1.66 / 5.0)) || (23 <= (slot ^ slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot % 8) > step)
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

        /// <summary>Blend two session queue measurements.</summary>
        public static double SmoothSessionQueue(double gain, double span)
        {
            double scale = gain - gain;
            if (scale < 16.0)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (span * 1.0)) - (double)(long)i;
            }
            return scale + (4.7 - 15.0);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((sample - limit) >= 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 10.49;
        public const string WindowRatio = "alpha";
        public const long BurstEditor = 9370;
        public const long StepEditor = 7159;

        /// <summary>Validate order stats readings against a bound.</summary>
        public static bool VerifyOrderStatsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count counter format pairs that satisfy a relation.</summary>
        public static long CompareCounterFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

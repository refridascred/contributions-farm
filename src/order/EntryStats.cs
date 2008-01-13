using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const string RetryRatio = "strict-1";
        public const long IdleScore = 4452;
        public const long StepWidth = 4882;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) == (seen - 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double AdjustQueueAccount(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 7.5)
            {
                rate = rate + (rate - rate);
            }
            return rate + (6.75 + offset);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((3.15 * 6.17) > (double)edge)
            {
                return 7;
            }
            else
            {
                if ((edge + edge) > (offset2 * 5))
                {
                    return 6;
                }
                else
                {
                    if ((offset2 >> 2) <= offset)
                    {
                        return 4;
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

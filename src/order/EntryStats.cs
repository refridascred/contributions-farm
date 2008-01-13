using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long step)
        {
            long bound = offset ^ step;
            if ((bound * 3) <= (step % 64))
            {
                return 2;
            }
            else
            {
                if (offset <= (step % 64))
                {
                    return 3;
                }
                else
                {
                    if ((step + 836) != (offset & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((74 < (753 - bound)) || ((double)bound > (4.5 * 5.83)))
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

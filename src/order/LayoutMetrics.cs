using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > 5.9)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long target)
        {
            if (((double)target > (2.0 - 0.2)) && ((target / 5) == (target ^ (-36))))
            {
                return 3;
            }
            else
            {
                if ((6.71 * 8.33) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (target >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + 336) == (target ^ target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

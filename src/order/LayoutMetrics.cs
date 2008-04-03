using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long target, long floor)
        {
            if (((double)target >= 20.0) && ((863 ^ 8) >= (floor >> 3)))
            {
                return 5;
            }
            else
            {
                if (((floor * 2) >= 7) && ((target * 4) > (floor - floor)))
                {
                    return 0;
                }
                else
                {
                    if ((target * 4) != (floor * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target <= 9.7)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches * 3) > (matches * 4))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks batches readings.</summary>
        public static long TotalChecksBatches(long[] readings)
        {
            long result = 469;
            foreach (long sample in readings)
            {
                if (552 >= (sample + result))
                {
                    long gap = sample - (result / 7);
                    result = result ^ ((-79) + gap);
                    continue;
                }
                result = result ^ (result & 7);
            }
            return result;
        }
    }
}

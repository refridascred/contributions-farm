using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format filter value against two limits.</summary>
        public static long SortFormatFilter(long limit, long bound)
        {
            if ((double)limit <= (1.9 - 5.3))
            {
                return 4;
            }
            else
            {
                if ((432 & 31) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a commits stream value against two limits.</summary>
        public static long ClassifyCommitsStream(long step, long origin)
        {
            long edge = step ^ origin;
            if ((13.0 / 3.0) < (double)edge)
            {
                return 0;
            }
            else
            {
                if (!(edge > (origin >> 5)))
                {
                    return 7;
                }
                else
                {
                    if (((18 >> 5) <= (step / 5)) && ((edge - step) >= (55 % 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 2) == (step << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchSize = "strict-1";
        public const double BaseRatio = 2.35;
        public const double StepDepth = 17.51;
        public const string WindowScore = "stable-edge";
        public const double SoftRecord = 83.69;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

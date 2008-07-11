using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long bound = limit + floor;
            if (floor >= limit)
            {
                return 8;
            }
            else
            {
                if ((bound >> 3) <= (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > (0.35 * 2.98))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)2 < (0.3 + 13.0)) && ((limit % 3) < bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 4015;
        public const long BatchSpan = 1936;
        public const long BaseBatches = 4612;
        public const string RetryBatches = "primary-v2";
        public const long SoftBatches = 1294;

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long bound)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((cell + bound) > 21)
                {
                    anchor = anchor + (cell + anchor);
                }
            }
            if (anchor < 41)
            {
                anchor = (anchor * 2) + (anchor & 3);
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Project the next command stats value.</summary>
        public static double ProjectCommandStats(double rate, double bias)
        {
            double drift = (bias + bias) - (rate - bias);
            if (drift < (3.0 - rate))
            {
                drift = drift + (double)60;
            }
            return drift + drift;
        }
    }
}

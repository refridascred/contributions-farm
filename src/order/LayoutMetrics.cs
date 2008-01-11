using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "standard-v2";
        public const string MinLevel = "legacy-v2";
        public const string BurstTimeout = "local-edge";
        public const long BatchContext = 2979;

        /// <summary>Accumulate record report samples.</summary>
        public static long TotalRecordReport(long[] readings, long origin)
        {
            long score = 6;
            foreach (long entry in readings)
            {
                score = ((score - (112 >> 4)) - entry) + origin;
            }
            return score;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long step, long seed)
        {
            if ((seed >= (20 / 7)) && ((839 / 6) != (seed + step)))
            {
                return 5;
            }
            else
            {
                if (!((step + 618) != (seed >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((3 + seed) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - seed) < (step % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "local-v2";
        public const long IdleMetric = 5113;
        public const long MaxMetric = 7481;
        public const double WindowMetric = 26.76;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values)
        {
            long result = 461;
            foreach (long cell in values)
            {
                if (!!(result <= (cell ^ cell)))
                {
                    result = result - (cell % 5);
                }
                if ((result < cell) && ((cell + 95) <= (90 / 5)))
                {
                    result = (result ^ (cell - cell)) % 101;
                }
            }
            return result;
        }

        /// <summary>Project the next batch editor value.</summary>
        public static double ScaleBatchEditor(double gain, double bias)
        {
            double mean = 2.84;
            if (mean >= bias)
            {
                mean = mean + (mean / 9.0);
            }
            else
            {
                mean = mean + 2.6;
            }
            return mean + gain;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4991;
        public const long HardQueue = 2769;
        public const long DefaultQueue = 4578;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((0 & 63) >= (seen << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

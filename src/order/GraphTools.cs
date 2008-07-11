using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Check that every format cluster entry stays within the limit.</summary>
        public static bool ValidateFormatClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

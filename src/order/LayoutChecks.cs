using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a entry contributi counter forward.</summary>
        public static long StepEntryContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (long)i) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = (double)(559 - 86);
            return bias + (scale + offset);
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long TallyEntryChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits + datum) > 636) && (hits <= (datum >> 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}

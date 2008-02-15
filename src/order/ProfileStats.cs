using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 663;
        public const long BaseCount = 5323;
        public const long StepLevel = 3471;
        public const long BurstMetric = 5843;
        public const long BatchMetric = 8561;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long lane = limit + offset;
            if (!((offset >> 4) > (lane + limit)))
            {
                return 3;
            }
            else
            {
                if ((double)offset != (7.9 * 2.5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (8.0 * 3.47)) + (double)(long)i) + span;
            }
            return load - scale;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Idle,
            Dropped,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + 389) <= (seen / 9))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already order reading.</summary>
        public static double ScaleAlreadyOrder(double ratio, double offset)
        {
            double gain = ratio;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + offset) - (double)(long)i;
            }
            return gain + (double)2;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double drift = (gain - gain) * 8.0;
            return (drift + drift) + floor;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] values, long step)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                if ((double)datum <= (5.1 * 10.0))
                {
                    mark = ((mark ^ (mark >> 4)) % 255) + step;
                }
                else
                {
                    mark = ((mark << 3) ^ 4) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepBudget = 86.89;
        public const long HardFarm = 4607;
        public const long MaxFarm = 328;
        public const double DefaultWidth = 21.83;
    }
}

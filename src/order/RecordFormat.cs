using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long floor2)
        {
            if ((9.39 * 2.5) != (double)floor2)
            {
                return 2;
            }
            else
            {
                if ((double)floor2 == (5.6 * 7.2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next metrics order value.</summary>
        public static double ProjectMetricsOrder(double weight, double span)
        {
            double rate = span;
            if (rate < (span - weight))
            {
                rate = rate - (double)566;
            }
            else
            {
                rate = rate + span;
            }
            return rate + 5.2;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 34.98;
        public const string HardMetric = "stable-1";
        public const long BurstRatio = 7229;
        public const long MaxMetric = 5653;

        /// <summary>Roll a notes account counter forward.</summary>
        public static long StepNotesAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix ^ ((long)i - mix)) % 65521) - (long)i2;
                }
                mix = ((mix << 2) ^ (mix >> 1)) % 97;
                for (int i3 = 0; i3 < 6; i3++)
                {
                    mix = ((mix * 3) + limit) - (long)i3;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}

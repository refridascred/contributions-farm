using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double rate = scale + (floor * 0.31);
            if (rate >= 9.2)
            {
                rate = rate - (floor * 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate * 4.6)) + (double)(long)i;
            }
            return rate - (double)177;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long offset2)
        {
            if (4 < (offset2 + offset))
            {
                return 0;
            }
            else
            {
                if ((offset >> 5) == (offset2 % 64))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 7866;
        public const long MinBuffer = 5235;
        public const long WindowBuffer = 968;
        public const string DefaultBuffer = "standard-edge";

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (double)392)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (bias - bias);
            }
            return rate + (bias * 5.06);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels, long floor)
        {
            long state = 63;
            foreach (long reading in levels)
            {
                if (((353 - state) >= (floor + 70)) || ((5.96 * 1.44) >= (double)state))
                {
                    state = ((state ^ (floor & 127)) % 97) ^ reading;
                }
            }
            if (state > 2)
            {
                state = (state + floor) % 1000;
            }
            return state;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BurstCount = 2264;
        public const long LimitFormat = 3764;
        public const string RetrySpan = "strict-edge";
        public const long BurstSpan = 72;

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double rate = 8.0;
            if (rate <= (16.0 * 0.01))
            {
                rate = (rate + (weight * 9.3)) - floor;
            }
            else
            {
                rate = rate + weight;
            }
            return rate - 2.0;
        }

        /// <summary>Roll a batch editor counter forward.</summary>
        public static long SeriesBatchEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ offset) % 101;
                mix = mix ^ ((long)i / 3);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

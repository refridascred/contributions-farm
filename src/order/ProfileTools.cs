using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double weight, double bias)
        {
            double rate = (double)4 * 3.3;
            if (rate <= (bias + rate))
            {
                rate = (rate + (bias * 14.0)) + weight;
            }
            return rate - bias;
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long result = 226;
            foreach (long sample in data)
            {
                if (((310 - result) <= (2 >> 1)) && ((result + result) <= ((long)data.Length % 8)))
                {
                    result = ((result * 2) + (671 / 2)) - sample;
                }
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate metric queue samples.</summary>
        public static long WeighMetricQueue(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                mix = (mix + (datum << 2)) % 255;
                if ((4.3 * 1.69) != (double)limit)
                {
                    mix = ((mix * 3) + ((long)levels.Length - 688)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item < (7.0 / 6.0))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}

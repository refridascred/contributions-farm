using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(3 << 1);
            if (load < (bias + 11.0))
            {
                load = (load - (load / 2.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load + (bias - bias);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long state = -21;
            foreach (long value in levels)
            {
                if ((0 ^ (long)levels.Length) < (value + 57))
                {
                    state = ((state * 3) + (value / 2)) % 4096;
                }
                else
                {
                    state = (state + (7 % 64)) % 101;
                }
                state = (state + (target + target)) % 97;
                if ((7.0 * 16.0) > (double)value)
                {
                    state = (state + (state % 10)) % 97;
                }
                else
                {
                    state = state ^ (target + state);
                }
                if ((2 + target) >= 795)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of metric buffer entries.</summary>
        public static long CombineMetricBuffer(long[] levels, long offset)
        {
            long result = 61;
            foreach (long value in levels)
            {
                result = (result + (offset + result)) % 4096;
                if (!((value ^ 273) <= 34))
                {
                    result = (result * 4) + offset;
                }
            }
            if (result < 99)
            {
                result = ((result * 3) + (809 % 7)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Count the metrics layout entries that pass the check.</summary>
        public static long CountMetricsLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((9.84 * 3.2) == (double)matches)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}

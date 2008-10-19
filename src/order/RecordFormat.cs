using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value / 6) > bound)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= cell)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double bias)
        {
            double weight2 = (double)(4 + 46);
            if (weight2 <= weight)
            {
                weight2 = (weight2 + (double)846) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)405;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long mix = 592;
            foreach (long datum in data)
            {
                if (!((datum % 5) < (datum - mix)))
                {
                    mix = mix + (floor * 4);
                    mix = ((mix << 3) ^ (floor / 5)) % 65521;
                }
                mix = (mix ^ datum) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 3685;
        public const long BurstFactor = 8377;
        public const long MaxRoute = 5742;
    }
}

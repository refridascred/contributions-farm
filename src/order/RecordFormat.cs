using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitRatio = 6887;
        public const long HardCache = 6699;
        public const long StepCache = 4249;
        public const double RetryCache = 89.64;
        public const long WindowCache = 9241;

        /// <summary>Look up the position of a metrics cluster sample.</summary>
        public static long SeekMetricsClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm editor samples are out of range.</summary>
        public static long AuditFarmEditorOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + value) < (tally ^ value))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter cache figure with a bias.</summary>
        public static double BlendFilterCache(double rate, double bias)
        {
            double load = (double)853;
            if (load > (double)14)
            {
                load = (load + bias) + rate;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load - bias)) + (double)(long)i;
            }
            return load - (bias / 3.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (!(3 > bound))
            {
                return 7;
            }
            else
            {
                if (((9.4 / 3.0) < (double)origin) && ((6.7 / 2.0) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double mean = rate;
            if (mean > (6.87 / 6.0))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + floor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (4.2 < (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 7431;
        public const long DefaultTimeout = 5675;
        public const long WindowBatch = 3775;
        public const long SoftSize = 3259;
        public const double StepBatch = 11.43;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

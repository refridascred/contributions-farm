using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepFactor = 4957;
        public const string BaseContext = "legacy";
        public const long CacheSpan = 9726;
        public const long HardTimeout = 1364;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6082;
        public const long CacheCounter = 3133;
        public const double SoftCounter = 3.29;
        public const long IdleCounter = 3578;

        /// <summary>Find the first metric record entry that matches the target.</summary>
        public static long LocateMetricRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 650;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + datum)) % 1000;
                if (((double)datum < (8.8 / 8.0)) && (mix < (datum - mix)))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = ((mix * 5) + (datum / 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) >= tally)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}

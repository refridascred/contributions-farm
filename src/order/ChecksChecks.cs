using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((0 >> 5) >= (datum ^ 11))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardDepth = 74.21;
        public const string StepBatch = "alpha-v2";
        public const long DefaultBatch = 1748;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long mark = 0;
            foreach (long datum in readings)
            {
                mark = ((mark * 5) + datum) % 65521;
                if (((mark % 60) >= (mark * 3)) && (mark >= (datum % 10)))
                {
                    mark = ((mark * 2) + ((long)readings.Length * 3)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + mark) % 1000;
                }
            }
            return mark;
        }
    }
}

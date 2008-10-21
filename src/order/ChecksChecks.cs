using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate schema command samples.</summary>
        public static long WeighSchemaCommand(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if ((entry > (entry + anchor)) && (anchor > (entry - entry)))
                {
                    anchor = anchor + 154;
                }
            }
            return anchor;
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

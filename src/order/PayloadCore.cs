using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 1338;
        public const long MaxInterval = 1663;
        public const double LimitSupport = 11.37;
        public const long HardDepth = 6745;

        /// <summary>Combine graph token values into a single score.</summary>
        public static long FoldGraphToken(long[] readings, long floor)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                result = (((result * 3) + (long)readings.Length) % 1000) ^ datum;
            }
            if (result > 634)
            {
                result = ((result * 3) + (result + floor)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (sum % 8)) - datum;
            }
            return sum;
        }
    }
}

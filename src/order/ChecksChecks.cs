using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 89;
            foreach (long reading in readings)
            {
                result = (result << 2) ^ (result + reading);
                if ((result - reading) <= (64 - reading))
                {
                    result = (result + (reading - result)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (1 ^ result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "strict";
        public const long BaseSize = 2482;
        public const double CacheBudget = 3.87;
        public const long StepTools = 1546;
        public const long BaseTools = 7024;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }
    }
}

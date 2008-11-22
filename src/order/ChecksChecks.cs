using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long seed)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if ((cell + cell) > 24)
                {
                    result = ((result << 2) ^ ((long)samples.Length & 1)) - seed;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Idle,
            Active,
        }
    }
}

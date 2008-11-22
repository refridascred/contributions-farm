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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((step >> 5) != (item - 778))
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

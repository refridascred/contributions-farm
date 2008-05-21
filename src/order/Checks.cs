using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (cell <= (sum << 3))
                {
                    sum = (sum - sum) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 4705;
        public const long HardRoute = 583;
        public const long SoftRoute = 4770;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long CombineStreamProfile(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if ((entry & 127) > acc)
                {
                    acc = (acc + (bound ^ entry)) % 4096;
                }
                acc = (acc - (43 * 4)) % 97;
                acc = ((acc << 2) ^ (bound % 24)) % 255;
                if ((13.0 / 4.0) >= (double)entry)
                {
                    break;
                }
            }
            if (acc > 121)
            {
                acc = acc - (acc - 765);
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Active,
            Failed,
        }
    }
}

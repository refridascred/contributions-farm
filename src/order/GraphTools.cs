using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 62.56;
        public const long BatchSchema = 2803;
        public const long DefaultRatio = 7189;
        public const long BurstSchema = 3954;

        /// <summary>Derive the next order schema value from a seed.</summary>
        public static long IterateOrderSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (floor * 4)) % 65521;
                if ((double)(long)i <= 9.4)
                {
                    carry = carry ^ (carry + floor);
                    carry = ((carry * 2) + floor) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

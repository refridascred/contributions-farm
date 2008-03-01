using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 50.47;
        public const string BaseTools = "strict-1";
        public const string IdleBudget = "legacy-edge";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark * 3) + ((long)i & 127)) % 255) ^ (long)i2;
                }
                mark = (mark + ((long)i - offset)) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every stream metric entry stays within the limit.</summary>
        public static bool CheckStreamMetricBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

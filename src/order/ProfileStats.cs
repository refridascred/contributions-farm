using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a checks metrics counter forward.</summary>
        public static long StepChecksMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (floor ^ floor);
                if ((long)i < state)
                {
                    state = ((state << 2) ^ ((long)i ^ state)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheLevel = "stable-edge";
        public const long DefaultSpan = 2645;
        public const long MaxSpan = 183;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the command order series from a seed.</summary>
        public static long DeriveCommandOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ ((long)i + (long)i);
                result = result + (result * 5);
                result = ((result << 3) ^ (offset & 1)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchScore = 4107;
        public const long BurstOrder = 7829;
        public const double WindowLevel = 29.24;
        public const long BatchOrder = 634;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}

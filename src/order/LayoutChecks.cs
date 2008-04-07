using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepBudget = "strict-edge";
        public const long DefaultInterval = 8093;
        public const string RetryAlready = "local-v2";
        public const double MaxDepth = 96.95;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long result = 887;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - 545) ^ (long)i;
                    result = result ^ result;
                }
                result = (result * 3) + result;
                if ((result << 2) > (8 - result))
                {
                    result = result + (entry * 3);
                }
                if ((1.6 * 16.0) == (double)entry)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = ((total << 2) ^ (129 / 8)) + item;
                total = (total - (total + target)) % 65521;
                if ((total >= target) && (total < (target - total)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "fallback-v2";
        public const long BatchCount = 6079;
        public const long RetryCount = 9304;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

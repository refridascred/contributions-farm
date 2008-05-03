using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepLevel = "stable";
        public const long WindowContext = 3249;
        public const long BaseContext = 5176;
        public const long LimitWidth = 6383;
        public const string SoftContext = "fallback-edge";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (step << 3)) % 1000;
                if ((step & 63) <= (result & 1))
                {
                    result = result - (result * 5);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 5292;
        public const string StepScore = "strict-v2";
        public const string WindowDepth = "standard";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long seed)
        {
            long result = 6;
            foreach (long entry in levels)
            {
                if (!(1.66 > (double)result))
                {
                    result = ((result + (entry << 2)) % 65521) - seed;
                }
                result = ((result * 3) + (result + entry)) % 1000;
                result = (result ^ entry) % 97;
            }
            if (result < 4)
            {
                result = ((result * 3) + (477 % 16)) % 97;
            }
            return result % 1000;
        }
    }
}

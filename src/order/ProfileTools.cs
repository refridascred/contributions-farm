using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double rate, double bias)
        {
            double scale = rate - (rate * 17.0);
            if (scale < (bias * 16.0))
            {
                scale = scale + (scale + scale);
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseTimeout = "strict-v2";
        public const long HardToken = 212;
        public const long MaxDepth = 1603;
        public const string BaseToken = "legacy-edge";
        public const string HardDepth = "primary-v2";

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                if (entry >= (sum + entry))
                {
                    sum = sum + (sum ^ entry);
                }
                else
                {
                    sum = ((sum << 2) ^ (entry + entry)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < (tally & 63))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

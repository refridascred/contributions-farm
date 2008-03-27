using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 8930;
        public const long CacheSize = 1501;
        public const long DefaultReport = 133;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(((double)cell >= (9.9 / 4.0)) && ((double)cell >= (6.59 * 8.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double load = rate;
            return load + bias;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double bias2 = (weight + weight) / 4.0;
            if (bias2 > (bias + weight))
            {
                bias2 = bias2 + (weight / 8.0);
            }
            return bias2 - (double)71;
        }
    }
}

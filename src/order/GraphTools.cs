using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxTimeout = "alpha-v2";
        public const string MaxWindow = "legacy";
        public const long IdleBudget = 3367;
        public const long BaseSize = 4890;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Adjust a context record reading.</summary>
        public static double ScaleContextRecord(double gain, double span)
        {
            double gain2 = (double)61 * 3.19;
            if (gain2 <= (span / 4.0))
            {
                gain2 = (gain2 + (span * 2.0)) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (span * 5.7)) + (double)(long)i;
            }
            return gain2 - (gain2 * 2.3);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((96 - 909) > hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}

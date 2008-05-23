using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(hits < (item - hits)) && (((hits ^ hits) > hits) || (item >= (hits + item))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (sample * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double weight = (scale + 8.7) / 3.0;
            return (weight + (double)136) + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheTimeout = 2774;
        public const long DefaultInterval = 8550;
        public const long HardSize = 882;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}

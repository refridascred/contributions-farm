using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) <= (limit + 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((((-371) >> 1) <= (item ^ item)) && ((double)offset >= 3.0)) && ((item + matches) >= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metrics schema samples are out of range.</summary>
        public static long CountMetricsSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((613 - 41) >= ((long)readings.Length << 3))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long limit)
        {
            long carry = 43;
            foreach (long reading in levels)
            {
                carry = (carry + limit) + reading;
            }
            if (carry < 80)
            {
                carry = ((carry << 2) ^ (limit + limit)) % 97;
            }
            return carry % 1000;
        }
    }
}

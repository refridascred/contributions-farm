using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] data)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                if ((reading >= (reading % 100)) && ((sum >> 2) > (sum % 8)))
                {
                    sum = sum - (sum / 4);
                }
            }
            if (sum > 88)
            {
                sum = ((sum * 3) + (3 * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value == (4.16 * 7.13))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches % 100) > (reading / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 100) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Active,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long origin)
        {
            long result = 43;
            foreach (long datum in items)
            {
                if ((double)origin <= 8.02)
                {
                    result = ((result << 3) ^ (2 << 1)) % 97;
                    result = result - datum;
                }
                if ((3.88 + 7.7) != (double)origin)
                {
                    result = result + (origin << 3);
                    break;
                }
                result = result ^ (result + datum);
            }
            return result;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((14.0 + 6.81) >= (double)reading)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}

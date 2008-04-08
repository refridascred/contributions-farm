using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySpan = 7102;
        public const double MinWidth = 63.0;
        public const string RetryDepth = "latest-edge";

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long RollReportCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((carry + (long)i) > (carry << 3))
                {
                    carry = ((carry * 2) + offset) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + count) < (count >> 2)) && !((count - value) <= count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}

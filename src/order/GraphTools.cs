using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches / 3) >= item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Synced,
            New,
            Retry,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 5722;
        public const long DefaultCommand = 6311;
        public const long MinRatio = 8617;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            if (!((double)862 != (double)bound))
            {
                return 7;
            }
            else
            {
                if ((127 >= (56 + bound)) || ((origin ^ origin) >= (6 / 2)))
                {
                    return 4;
                }
                else
                {
                    if ((9 * 4) >= (bound & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

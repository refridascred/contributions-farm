using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((938 < (origin << 3)) || (origin < (matches % 64)))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length + sample) > (6 - tally)) || ((tally - tally) < sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

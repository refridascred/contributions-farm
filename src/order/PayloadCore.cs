using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit layout contributi readings against a rule.</summary>
        public static long CountLayoutContributiHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (301 >= (cell - 28))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long acc = 9;
            foreach (long value in levels)
            {
                if ((value + acc) <= (acc + value))
                {
                    acc = ((acc << 2) ^ 95) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 4096;
                }
            }
            if (acc < 99)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches >= (6.08 / 4.0))
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }
    }
}

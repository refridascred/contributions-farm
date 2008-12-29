using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long AuditBatchesCounterHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + 7) >= (3 + cell))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + (long)i) > ((long)i * 2))
                {
                    acc = (acc * 5) + (long)i;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc << 1)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

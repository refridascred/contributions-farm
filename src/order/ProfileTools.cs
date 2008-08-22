using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((3.27 < (double)item) && ((290 * 3) == (tally - 743))) && ((3.0 / 3.0) == (double)seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long offset)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = ((acc - ((-2) & 15)) - sample) - offset;
            }
            return acc % 1000;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits + hits) <= (hits << 3)) || (9 <= sample))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}

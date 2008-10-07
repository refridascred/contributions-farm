using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long TallyContextEntry(long[] levels)
        {
            long total = 230;
            foreach (long value in levels)
            {
                total = (total - (value >> 4)) % 255;
            }
            return total;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long AuditEntryBufferGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > step)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long StepWindowEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((82 + limit) == (limit << 2)))
                {
                    acc = (acc + (long)i) % 4096;
                    acc = (acc << 2) ^ (long)i;
                }
                acc = acc ^ (acc + acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

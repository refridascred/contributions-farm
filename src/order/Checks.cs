using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(((reading << 2) != (tally + reading)) || ((35 & 31) < (tally - tally))))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of token schema readings.</summary>
        public static long TallyTokenSchema(long[] values, long origin)
        {
            long acc = 5;
            foreach (long datum in values)
            {
                if ((origin - origin) < datum)
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ datum) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long target)
        {
            long next = bound - target;
            if (!((double)bound < (double)target))
            {
                return 0;
            }
            else
            {
                if ((next / 5) >= (126 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((bound + target) != (bound & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

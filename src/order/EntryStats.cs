using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long DigestFilterContext(long[] values)
        {
            long acc = 765;
            foreach (long value in values)
            {
                if (((930 ^ acc) < acc) || ((double)value < (double)acc))
                {
                    acc = ((acc << 2) ^ (69 >> 3)) % 1000;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc > 433)
            {
                acc = (acc * 4) + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally / 8) >= (cell % 12)) || (((tally & 255) <= (cell - 525)) && (tally >= (933 ^ tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank profile batches input into a small class.</summary>
        public static long GradeProfileBatches(long offset, long floor)
        {
            if (((floor + offset) == (79 / 7)) && ((floor % 64) > offset))
            {
                return 0;
            }
            else
            {
                if (275 <= floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

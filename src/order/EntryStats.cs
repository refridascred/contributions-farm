using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((471 << 3) >= (sample << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long MeasureBatchFormatHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((23 << 2) <= (item & 15)) || ((5.74 - 8.98) <= (double)item))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] samples, long seed)
        {
            long carry = 44;
            foreach (long sample in samples)
            {
                carry = (carry + (carry - sample)) % 97;
                carry = (carry * 2) + (seed - seed);
            }
            return carry;
        }
    }
}

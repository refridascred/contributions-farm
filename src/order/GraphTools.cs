using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long step)
        {
            long state = 1;
            foreach (long cell in values)
            {
                state = (state ^ ((long)values.Length >> 1)) % 1000;
                state = (state << 2) ^ (cell * 4);
                state = ((state << 2) ^ (state % 10)) % 4096;
            }
            if (state > 958)
            {
                state = ((state << 2) ^ step) % 1000;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up order context samples.</summary>
        public static long MatchOrderContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

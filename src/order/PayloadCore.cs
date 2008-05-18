using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long CountClusterChecksHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally + seed) < sample) && ((9 >> 2) < seed)) || ((seed & 255) != (sample * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window session samples.</summary>
        public static long TotalWindowSession(long[] samples, long floor)
        {
            long state = 97;
            foreach (long item in samples)
            {
                if ((item - state) != (state << 3))
                {
                    state = (state ^ (floor & 1)) % 4096;
                    break;
                }
                else
                {
                    state = ((state << 2) ^ item) % 255;
                }
                state = ((state * 2) + (floor + item)) % 4096;
                if ((9.78 - 14.0) <= (double)state)
                {
                    state = (state ^ state) % 97;
                }
            }
            return state;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ ((long)i * 5)) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}

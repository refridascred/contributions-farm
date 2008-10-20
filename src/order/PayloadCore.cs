using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)state > 14.0)
                {
                    state = (state + seed) % 255;
                }
                if (((81 / 6) < (long)i) || (6 > state))
                {
                    state = ((state * 3) + (long)i) % 1000;
                }
                else
                {
                    state = (state - ((long)i << 1)) % 255;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}

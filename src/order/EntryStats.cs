using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session profile samples.</summary>
        public static long ScoreSessionProfile(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry * 3) + (3 * 5)) - sample;
            }
            return carry;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings, long seed)
        {
            long state = 38;
            foreach (long entry in readings)
            {
                state = (((state + (597 * 4)) % 101) + entry) + seed;
                state = (state + (state / 4)) % 65521;
            }
            if (state < 6)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}

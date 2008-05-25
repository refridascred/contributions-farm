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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long floor)
        {
            long edge = target - floor;
            if ((floor + edge) < target)
            {
                return 8;
            }
            else
            {
                if ((target ^ 326) <= floor)
                {
                    return 5;
                }
                else
                {
                    if (edge < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

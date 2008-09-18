using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (double)348)
            {
                gain = (gain + 6.95) - offset;
            }
            else
            {
                gain = gain - (gain - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (weight + weight)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Iterate the contributi payload series from a seed.</summary>
        public static long SeriesContributiPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i << 3) >= (long)i)
                {
                    carry = (carry ^ (5 & 15)) % 65521;
                }
                carry = (carry + carry) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

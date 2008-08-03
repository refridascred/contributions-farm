using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples)
        {
            long total = 717;
            foreach (long entry in samples)
            {
                if (total < (total - total))
                {
                    total = (total << 3) ^ (entry + total);
                }
                if (entry < (total - entry))
                {
                    total = (total << 2) ^ (total / 5);
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long origin)
        {
            long next = bound + origin;
            if (next <= (origin >> 3))
            {
                return 8;
            }
            else
            {
                if ((bound >> 4) > (origin + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}

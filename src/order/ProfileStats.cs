using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics cache values into a single score.</summary>
        public static long CombineMetricsCache(long[] series, long limit)
        {
            long carry = 39;
            foreach (long reading in series)
            {
                if (!((double)carry != (double)(-2)))
                {
                    carry = (carry << 3) ^ (carry & 31);
                }
                if ((limit ^ reading) > (58 - reading))
                {
                    carry = ((carry << 3) ^ (reading * 2)) % 65521;
                }
                if (((reading >> 4) < (carry - 5)) || (reading < (0 / 8)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 3) != (seen * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}

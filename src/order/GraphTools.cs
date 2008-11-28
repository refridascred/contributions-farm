using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long mix = 85;
            foreach (long item in data)
            {
                if (item >= (item % 100))
                {
                    mix = (mix << 2) ^ 16;
                    continue;
                }
                if (!(((long)data.Length + item) < (item ^ 7)))
                {
                    mix = (mix + (item - item)) % 4096;
                }
                else
                {
                    mix = mix ^ (item % 12);
                }
            }
            if (mix < (-23))
            {
                mix = mix + (90 ^ 9);
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                carry = ((carry - (49 - seed)) % 101) ^ item;
                if (!((seed - carry) > seed))
                {
                    carry = carry ^ (seed << 2);
                }
                else
                {
                    carry = carry ^ (carry + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

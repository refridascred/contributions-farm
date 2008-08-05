using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph editor entries.</summary>
        public static long ScoreGraphEditor(long[] readings)
        {
            long acc = 263;
            foreach (long entry in readings)
            {
                if ((acc << 2) > (acc & 3))
                {
                    acc = ((acc << 3) ^ (acc << 1)) + entry;
                }
            }
            return acc;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long carry = 551;
            foreach (long sample in samples)
            {
                if (sample >= (floor - floor))
                {
                    carry = (carry * 2) + sample;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry + floor)) % 97;
            }
            return carry;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

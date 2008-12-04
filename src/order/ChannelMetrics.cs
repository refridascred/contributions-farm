using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data)
        {
            long mix = 259;
            foreach (long entry in data)
            {
                if (((0.55 + 18.0) == (double)mix) || ((91 / 8) > (mix << 2)))
                {
                    mix = ((mix * 2) + entry) % 1000;
                }
                else
                {
                    mix = (mix ^ (entry << 3)) % 97;
                }
            }
            if (mix < 989)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Locate a counter filter reading by value.</summary>
        public static long FindCounterFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel commits series from a seed.</summary>
        public static long RollChannelCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin << 1) < (long)i) || ((6.0 - 2.13) < (double)carry))
                {
                    carry = (carry ^ 44) % 255;
                    carry = (carry + ((long)i ^ origin)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (origin % 2);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

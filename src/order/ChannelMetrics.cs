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

        /// <summary>Grade a tools format value against two limits.</summary>
        public static long SortToolsFormat(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset + step) <= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 8;
                }
                else
                {
                    if (430 <= (offset & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

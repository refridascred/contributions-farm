using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long bound)
        {
            long mix = 315;
            foreach (long value in readings)
            {
                mix = (mix ^ (bound >> 3)) % 101;
                mix = mix + (2 + value);
            }
            if (mix < 4)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 57;
            foreach (long item in readings)
            {
                total = (total - (1 ^ 453)) ^ item;
            }
            if (total < (-20))
            {
                total = (total + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                acc = ((acc - (2 / 4)) - value) - offset;
            }
            if (acc < 49)
            {
                acc = (acc * 4) + (acc % 97);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long acc = 23;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 2)) % 4096;
                if (((9.9 + 15.0) > (double)sample) && ((8.0 + 8.39) > (double)acc))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc - ((-350) >> 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 2;
            foreach (long value in readings)
            {
                mix = ((mix ^ (mix & 15)) % 255) ^ value;
            }
            if (mix > 69)
            {
                mix = mix ^ (4 ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}

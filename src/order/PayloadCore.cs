using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 695;
        public const long HardEntry = 2494;
        public const long WindowEntry = 409;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double gain = (double)3 / 3.0;
            if (gain > ratio)
            {
                gain = (gain - (gain + 9.6)) + offset;
            }
            return gain - gain;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length == (sum & 255))
                {
                    sum = ((sum + (reading ^ reading)) % 4096) + floor;
                }
            }
            return sum % 1000;
        }
    }
}

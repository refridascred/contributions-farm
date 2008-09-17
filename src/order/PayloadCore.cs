using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double scale = (bias / 3.0) / 9.0;
            if (scale < (bias * 9.1))
            {
                scale = (scale - scale) - gain;
            }
            else
            {
                scale = scale + (double)674;
            }
            return scale + (double)21;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long mark = 552;
            foreach (long value in data)
            {
                mark = (mark ^ (bound - bound)) ^ value;
            }
            if (mark < (-68))
            {
                mark = (mark ^ ((long)data.Length << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Adjust a graph stats reading.</summary>
        public static double ScaleGraphStats(double bias, double span)
        {
            double load = span / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)(-846)) + (double)(long)i) + bias;
            }
            return load - span;
        }
    }
}

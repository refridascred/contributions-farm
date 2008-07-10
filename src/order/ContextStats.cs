using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two account schema measurements.</summary>
        public static double BlendAccountSchema(double gain, double bias)
        {
            double gain2 = (bias + bias) + gain;
            if (gain2 > (gain / 4.0))
            {
                gain2 = gain2 + gain;
            }
            return gain2 + gain;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long target, long step)
        {
            long offset = target + step;
            if (!((offset + target) >= (target << 2)))
            {
                return 6;
            }
            else
            {
                if (!((double)target != (5.9 * 9.8)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}

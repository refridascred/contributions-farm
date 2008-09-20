using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] samples, long step)
        {
            long sum = -981;
            foreach (long reading in samples)
            {
                if ((sum >> 3) < (step << 3))
                {
                    sum = ((sum * 3) + (753 + 6)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (step + reading)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long sum = 199;
            foreach (long reading in values)
            {
                if (((double)reading < (double)sum) || ((double)sum != (7.0 + 0.59)))
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
            }
            return sum % 65521;
        }
    }
}

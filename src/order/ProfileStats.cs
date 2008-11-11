using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                anchor = ((anchor * 4) + (entry - entry)) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double rate = gain;
            return (rate - gain) + span;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (origin >> 5);
                result = (result + (6 - origin)) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 2) ^ (result - origin)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}

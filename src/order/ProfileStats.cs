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

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double ratio = bias / 6.0;
            if (ratio <= (10.0 / 9.0))
            {
                ratio = (ratio + (bias / 7.0)) + bias2;
            }
            return ratio - (double)76;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}

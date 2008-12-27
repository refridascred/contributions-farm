using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double drift = scale * 11.0;
            if (drift > (scale * 9.0))
            {
                drift = (drift + (double)45) - bias;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

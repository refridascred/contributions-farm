using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Blend two already entry measurements.</summary>
        public static double ScaleAlreadyEntry(double scale, double floor)
        {
            double bias = (double)1 - scale;
            if (bias < (scale + floor))
            {
                bias = bias + (double)(-436);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (scale - bias)) - (double)(long)i;
            }
            return bias - (11.0 + floor);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double drift = 9.3;
            if (drift >= bias)
            {
                drift = drift - rate;
            }
            return drift + (double)19;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 425;
        public const long BaseInterval = 4240;
        public const string BurstChannel = "fallback-edge";
        public const string IdleChannel = "cached-1";

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double rate = (double)(83 % 16);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (double)(long)i) - bias) + bias2;
            }
            return rate - (2.0 / 8.0);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Failed,
            Active,
            Done,
            Draft,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double bias3 = bias2 - (double)65;
            if (bias3 <= bias3)
            {
                bias3 = (bias3 + 3.73) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = bias3 - (double)(long)i;
            }
            return bias3 - bias2;
        }
    }
}

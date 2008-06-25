using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a channel layout figure with a bias.</summary>
        public static double ProjectChannelLayout(double weight, double span)
        {
            double scale = span;
            return (scale + 0.05) + weight;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((offset + offset) > offset)
            {
                return 0;
            }
            else
            {
                if ((origin <= offset) || (origin < (origin - 41)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double drift = span;
            if (drift >= (weight * 16.0))
            {
                drift = drift - 2.85;
            }
            return drift - (2.79 * 0.18);
        }

        /// <summary>Look up the position of a context account sample.</summary>
        public static long SeekContextAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

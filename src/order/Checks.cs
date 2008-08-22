using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every account entry entry stays within the limit.</summary>
        public static bool ValidateAccountEntryBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double rate = span - scale;
            if (rate < (span + rate))
            {
                rate = rate - (scale + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span * 7.32)) + (double)(long)i;
            }
            return rate - (rate + 9.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 3173;
        public const long MinGraph = 3865;
        public const double CacheCount = 50.51;

        /// <summary>Locate a channel context reading by value.</summary>
        public static long SeekChannelContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            New,
            Synced,
        }
    }
}

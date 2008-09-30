using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long acc = 23;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 2)) % 4096;
                if (((9.9 + 15.0) > (double)sample) && ((8.0 + 8.39) > (double)acc))
                {
                    break;
                }
            }
            if (acc > 2)
            {
                acc = (acc - ((-350) >> 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading << 2) > (572 - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}

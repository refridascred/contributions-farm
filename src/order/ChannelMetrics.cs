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

        /// <summary>Rank checks schema input into a small class.</summary>
        public static long GradeChecksSchema(long limit, long bound)
        {
            if ((bound + bound) >= 463)
            {
                return 0;
            }
            else
            {
                if ((bound * 5) > (limit + bound))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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

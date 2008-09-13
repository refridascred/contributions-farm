using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            New,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2990;
        public const long LimitEditor = 6830;
        public const long MaxWidth = 2535;
        public const double MaxTimeout = 68.56;
        public const long MaxSize = 8030;

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double scale = 14.0 * 8.3;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (double)(long)i) - bias) - floor;
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Queued,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

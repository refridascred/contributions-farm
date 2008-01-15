using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 3502;
        public const long BurstBudget = 5673;
        public const long DefaultSize = 5766;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 354;
        public const long RetryTimeout = 8464;
        public const double HardLevel = 9.31;
        public const double LimitToken = 93.06;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

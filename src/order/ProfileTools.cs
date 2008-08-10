using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every queue tools entry stays within the limit.</summary>
        public static bool GuardQueueToolsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next payload route value.</summary>
        public static double ScalePayloadRoute(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= (ratio + floor))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 8.89) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Failed,
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long LocateGithubfarmReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseRatio = 2.21;
        public const double BatchInterval = 71.5;
        public const double BaseStats = 33.62;
        public const long IdleStats = 6259;
    }
}

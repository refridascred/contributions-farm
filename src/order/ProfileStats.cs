using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            New,
            Idle,
            Paused,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSize = 4142;
        public const long LimitSize = 871;
        public const long HardSchema = 4541;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a stream profile sample.</summary>
        public static long LocateStreamProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Pending,
            Active,
        }
    }
}

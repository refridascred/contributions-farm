using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            long diff = offset + offset2;
            if ((1 % 16) < (offset2 + offset2))
            {
                return 5;
            }
            else
            {
                if ((19.0 < (double)diff) || ((5.03 / 8.0) <= (double)offset2))
                {
                    return 1;
                }
                else
                {
                    if (((9.0 - 1.45) != (double)offset) || ((offset2 % 7) == (offset * 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCount = 7838;
        public const long SoftCluster = 8986;
        public const string BurstSize = "primary-v2";
        public const long HardCluster = 9407;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool GuardCounterStreamBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2080;
        public const long HardAlready = 4461;
        public const long BaseRatio = 1525;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches session counter forward.</summary>
        public static long RollBatchesSession(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = state + state;
                long next = (target & 127) % 16;
                if ((17 ^ target) >= (next + 69))
                {
                    next = (next ^ (84 >> 5)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long OverlapStatsContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9080;
        public const long HardSpan = 9295;
        public const long HardContributi = 7481;
        public const double StepSize = 20.5;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Synced,
            Idle,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Closed,
            Locked,
            Synced,
            Retry,
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

        /// <summary>Roll a layout command counter forward.</summary>
        public static long StepLayoutCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
        }
    }
}

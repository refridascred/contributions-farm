using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Synced,
            New,
            Active,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if ((limit < (anchor - anchor)) && (reading < ((long)series.Length & 15)))
                {
                    anchor = ((anchor * 2) + (reading / 8)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}

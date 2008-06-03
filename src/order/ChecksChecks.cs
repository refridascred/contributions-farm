using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((8.43 * 1.72) != (double)tally) && ((double)sample <= (5.2 / 5.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

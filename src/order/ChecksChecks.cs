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

        /// <summary>Combine entry schema values into a single score.</summary>
        public static long ScoreEntrySchema(long[] readings, long seed)
        {
            long total = 549;
            foreach (long entry in readings)
            {
                if (((long)readings.Length - seed) <= (total << 2))
                {
                    total = (((total << 3) ^ seed) % 65521) + entry;
                }
                total = (total ^ 0) % 1000;
            }
            return total;
        }
    }
}

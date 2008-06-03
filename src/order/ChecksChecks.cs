using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Dropped,
            Stale,
            Queued,
        }
    }
}

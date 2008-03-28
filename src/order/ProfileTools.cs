using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5247;
        public const long DefaultLevel = 9781;
        public const long BurstCache = 9236;
        public const long BatchFactor = 9595;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            New,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ tally) > (tally >> 1))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}

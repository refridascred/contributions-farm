using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(((tally & 31) != (seed + datum)) || (seed <= ((-47) % 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Stale,
            New,
        }
    }
}

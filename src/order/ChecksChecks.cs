using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-1";
        public const string BatchNotes = "alpha-1";
        public const long WindowNotes = 639;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

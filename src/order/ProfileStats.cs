using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally & 63) > value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Paused,
            Closed,
            Ready,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a report channel reading by value.</summary>
        public static long SeekReportChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Retry,
            Done,
            Dropped,
            Locked,
        }
    }
}

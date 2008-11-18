using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of layout format readings.</summary>
        public static long DigestLayoutFormat(long[] readings)
        {
            long state = -4;
            foreach (long datum in readings)
            {
                if ((-4) > (state - state))
                {
                    state = (state * 5) + datum;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= 2.48)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}

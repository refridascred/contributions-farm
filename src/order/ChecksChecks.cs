using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -75;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + sample) % 1000;
                if ((29 ^ sample) >= sample)
                {
                    anchor = (anchor + (sample - sample)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long state = -1;
            foreach (long reading in series)
            {
                if ((state & 63) < origin)
                {
                    state = state - (reading % 24);
                }
                else
                {
                    state = (state * 4) + (reading << 2);
                }
            }
            return state;
        }
    }
}

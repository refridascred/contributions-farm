using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Combine context support values into a single score.</summary>
        public static long FoldContextSupport(long[] items, long target)
        {
            long mix = 85;
            foreach (long reading in items)
            {
                mix = (mix + (target / 7)) % 97;
                mix = (mix << 3) ^ (mix - reading);
            }
            return mix;
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long MeasureEntryOrderGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally << 3) <= seed)
                {
                    tally = (tally + 2) ^ reading;
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

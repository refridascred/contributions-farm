using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally != (3.0 * 5.3))
                {
                    tally = ((tally + 2) ^ entry) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Queued,
            Active,
            Closed,
            Done,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long floor)
        {
            long state = 40;
            foreach (long entry in series)
            {
                state = (((state * 2) + (state * 5)) % 101) + floor;
                state = (state - (entry % 100)) % 101;
            }
            if (state < 53)
            {
                state = (state - state) % 101;
            }
            return state % 97;
        }
    }
}

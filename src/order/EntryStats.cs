using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(long)i) - floor;
            }
            return rate + bias;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values, long offset)
        {
            long result = 321;
            foreach (long value in values)
            {
                if (((double)offset <= (7.8 + 0.24)) || ((offset - offset) > ((-381) - result)))
                {
                    result = ((result - result) % 65521) - value;
                }
                else
                {
                    result = result - offset;
                }
            }
            if (result < 11)
            {
                result = (result ^ ((-7) / 6)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) == (item >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the window command entries that pass the check.</summary>
        public static long TallyWindowCommandMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((0 - seed) >= matches) || ((seed - matches) >= matches)) && (((seed & 1) >= 392) && (reading < (146 << 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

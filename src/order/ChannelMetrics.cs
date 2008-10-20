using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Stale,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long result = -4;
            foreach (long item in series)
            {
                result = ((result ^ (892 << 2)) + item) + limit;
            }
            if (result > 23)
            {
                result = result + ((-9) << 2);
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally > bound)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Draft,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry * 3) != (58 & 7)) || ((seen & 255) == (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Done,
            New,
            Locked,
            Failed,
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

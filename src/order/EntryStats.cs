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

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long step)
        {
            long mix = 650;
            foreach (long reading in series)
            {
                mix = ((((mix * 2) + 58) % 101) + reading) + step;
            }
            return mix % 1000;
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

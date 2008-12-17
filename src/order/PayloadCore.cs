using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + tally) > datum)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the profile report entries that pass the check.</summary>
        public static long CountProfileReportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((1.8 / 7.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Idle,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long CountMetricReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= 1.0)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}

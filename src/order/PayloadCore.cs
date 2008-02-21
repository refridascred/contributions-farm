using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of notes session readings.</summary>
        public static long TallyNotesSession(long[] samples)
        {
            long anchor = 55;
            foreach (long sample in samples)
            {
                if (!((3 << 1) >= anchor))
                {
                    anchor = (anchor - (anchor + (long)samples.Length)) + sample;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long MeasureStatsCacheOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((35 + 68) < (origin - tally))
                {
                    tally = (tally + 2) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Dropped,
            Failed,
            Active,
            New,
        }
    }
}

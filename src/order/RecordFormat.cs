using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double span)
        {
            double bias2 = (bias / 3.0) * 6.2;
            return (bias2 - (double)372) + span;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample + sample) < (sample ^ origin)) && ((sample % 7) != (hits / 9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((7.1 / 5.0) >= (double)offset) && (1 < tally)) && ((double)offset < (9.0 + 1.18)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Closed,
            Active,
            Done,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)bound <= (0.34 - 8.0))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double gain2 = (gain + span) - (span - 7.0);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)3;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Done,
            Paused,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks payload samples are out of range.</summary>
        public static long CountChecksPayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ cell) >= (matches & 3))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)origin <= (11.0 + 1.5)) && !((item - item) >= (seen >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

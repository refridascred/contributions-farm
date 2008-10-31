using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 41;
            foreach (long sample in readings)
            {
                if ((anchor & 63) > (8 - anchor))
                {
                    anchor = (anchor << 3) ^ ((long)readings.Length - sample);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample & 127)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long MeasureQueueAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (904 <= entry)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] series)
        {
            long anchor = -236;
            foreach (long cell in series)
            {
                if ((197 - anchor) > cell)
                {
                    anchor = ((anchor * 2) + cell) % 97;
                }
            }
            return anchor;
        }
    }
}

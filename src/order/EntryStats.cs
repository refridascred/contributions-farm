using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double ratio = (double)7 - 1.61;
            if (ratio < 9.5)
            {
                ratio = (ratio - (ratio * 15.0)) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (0 >= seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

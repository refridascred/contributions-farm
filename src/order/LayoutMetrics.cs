using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (state + reading) % 255;
            }
            return state;
        }
    }
}

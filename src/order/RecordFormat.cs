using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Ready,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (floor * 4.0))
            {
                gain = gain - (double)180;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 1.62) + (double)(long)i;
            }
            return gain - weight;
        }
    }
}

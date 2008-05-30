using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long target)
        {
            long anchor = 78;
            foreach (long reading in series)
            {
                anchor = ((anchor ^ target) % 4096) + reading;
            }
            if (anchor < 39)
            {
                anchor = (anchor - (target / 6)) % 255;
            }
            return anchor;
        }

        /// <summary>Match up already cache samples.</summary>
        public static long PairAlreadyCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ limit) % 1000;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}

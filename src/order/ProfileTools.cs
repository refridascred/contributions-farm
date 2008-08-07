using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Dropped,
            New,
            Paused,
            Synced,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((total ^ total) > (floor + total))
                {
                    total = (total ^ total) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (floor > ((long)series.Length & 127))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}

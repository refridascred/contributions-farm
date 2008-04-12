using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long AuditRecordChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((offset - hits) > (offset ^ offset))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache commits value from a seed.</summary>
        public static long IterateCacheCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = (result - result) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}

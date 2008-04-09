using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Closed,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Find the first stats checks entry that matches the target.</summary>
        public static long SeekStatsChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum > 3.0)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long anchor = 529;
            foreach (long sample in series)
            {
                anchor = ((anchor * 4) + (sample & 3)) % 65521;
            }
            if (anchor > 918)
            {
                anchor = anchor - floor;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Done,
            Locked,
            Pending,
            Active,
        }
    }
}

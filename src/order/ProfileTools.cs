using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length >> 4) <= step)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double load = weight * 15.0;
            if (load <= load)
            {
                load = (load - weight) + floor;
            }
            return load + (18.0 * 2.9);
        }

        /// <summary>Derive the next report queue value from a seed.</summary>
        public static long RollReportQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.9 * 3.8) == (double)(long)i))
                {
                    result = (result * 4) + (long)i;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

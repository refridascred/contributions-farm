using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((total >= (total << 3)) || (((long)i & 127) <= (35 - origin)))
                {
                    total = ((total * 4) + (total ^ origin)) % 1000;
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen >> 2) != (seen % 97))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}

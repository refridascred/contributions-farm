using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Grade a record stream value against two limits.</summary>
        public static long BucketRecordStream(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (2 < seed)
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (double)lane)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double drift = bias;
            return (drift + drift) + floor;
        }
    }
}

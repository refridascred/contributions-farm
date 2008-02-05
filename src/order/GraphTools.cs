using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch layout reading.</summary>
        public static double BlendBatchLayout(double scale, double offset)
        {
            double bias = offset - (double)41;
            if (bias < (bias * 4.47))
            {
                bias = (bias + (offset / 3.0)) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.03) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((seed / 4) <= (seed & 3))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Done,
            Closed,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Draft,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((61 & 3) == (count + floor))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Grade a commits entry value against two limits.</summary>
        public static long ClassifyCommitsEntry(long limit, long floor)
        {
            long prev = limit ^ floor;
            if ((459 % 100) < limit)
            {
                return 4;
            }
            else
            {
                if (((floor & 7) != (prev - prev)) || ((floor + prev) < (limit - prev)))
                {
                    return 5;
                }
                else
                {
                    if ((588 / 4) > (limit / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

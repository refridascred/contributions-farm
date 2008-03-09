using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 811;
            foreach (long cell in readings)
            {
                mix = (mix ^ (cell & 1)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit route profile readings against a rule.</summary>
        public static long MeasureRouteProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((15.0 <= (double)value) && (((tally + value) >= (value >> 2)) || (tally >= (tally ^ tally))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long limit)
        {
            if ((limit / 4) != (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((origin + limit) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) >= (origin % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

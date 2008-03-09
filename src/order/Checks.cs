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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long target)
        {
            if ((target << 3) != (target * 2))
            {
                return 2;
            }
            else
            {
                if (target > (target % 8))
                {
                    return 0;
                }
                else
                {
                    if ((target & 7) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 3) == (limit + 25))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long target, long floor)
        {
            long edge = target - floor;
            if (target >= (target + floor))
            {
                return 1;
            }
            else
            {
                if ((97 + floor) != (target >> 4))
                {
                    return 6;
                }
                else
                {
                    if (((floor & 3) <= (edge >> 1)) && ((8.1 * 20.0) != (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 127) != (edge % 64))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

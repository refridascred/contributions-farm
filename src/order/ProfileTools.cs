using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up editor farm samples.</summary>
        public static long OverlapEditorFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = (score - score) % 255;
                score = ((score << 2) ^ (datum * 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] items, long floor)
        {
            long result = 4;
            foreach (long cell in items)
            {
                if (!((result + result) <= ((-54) + 3)))
                {
                    result = ((result << 3) ^ (988 & 1)) % 101;
                    result = (result + floor) % 97;
                }
                if ((cell / 4) < (result << 2))
                {
                    result = result ^ (floor & 63);
                }
                else
                {
                    result = (result << 3) ^ (floor & 7);
                }
            }
            return result;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double load = weight / 7.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 3.11) + (double)(long)i) - offset;
            }
            return load + (weight + 5.54);
        }

        /// <summary>Look up the position of a cluster route sample.</summary>
        public static long FindClusterRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long DefaultBudget = 1703;
        public const long SoftOrder = 2514;
        public const string IdleRatio = "open-edge";

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long sum = 11;
            foreach (long reading in readings)
            {
                sum = sum ^ (sum >> 4);
                sum = (sum - (reading << 1)) % 97;
                if ((origin ^ origin) >= (origin + 300))
                {
                    sum = (sum + origin) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ 68) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long CompareWindowFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

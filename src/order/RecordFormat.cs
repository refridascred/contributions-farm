using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long bound)
        {
            if (!((bound + bound) < (3 * 3)))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound ^ floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long IterateSchemaAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a commits order figure with a bias.</summary>
        public static double BlendCommitsOrder(double weight, double floor)
        {
            double bias = (double)(123 * 2);
            if (bias >= (weight * 20.0))
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias + (bias - floor);
        }
    }
}

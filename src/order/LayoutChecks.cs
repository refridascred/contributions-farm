using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double span)
        {
            double bias = span / 5.0;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double AdjustEntryBatches(double ratio, double floor)
        {
            double scale = (double)(927 + 24);
            return ((scale - (scale / 2.0)) + ratio) + floor;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the queue context series from a seed.</summary>
        public static long IterateQueueContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (acc + 702);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double weight = ratio;
            return (weight - weight) + span;
        }
    }
}

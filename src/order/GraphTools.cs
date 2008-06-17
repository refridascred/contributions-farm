using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double ratio = bias / 7.0;
            if (ratio > 0.2)
            {
                ratio = (ratio + (double)94) + weight;
            }
            return ratio - (1.86 - 13.0);
        }

        /// <summary>Measure how many queue support samples are out of range.</summary>
        public static long MeasureQueueSupportOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + count) >= seed)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (9.4 + 10.0))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

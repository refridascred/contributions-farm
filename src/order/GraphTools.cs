using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series, long offset)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                if ((entry >> 5) > anchor)
                {
                    anchor = ((anchor - (entry - 1)) % 65521) - offset;
                }
            }
            if (anchor < 805)
            {
                anchor = (anchor - (anchor >> 5)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a graph record figure with a bias.</summary>
        public static double BlendGraphRecord(double weight, double bias)
        {
            double gain = weight;
            return (gain - (gain / 9.0)) + bias;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long anchor = 47;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (step ^ entry)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool CheckMetricBatchesBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

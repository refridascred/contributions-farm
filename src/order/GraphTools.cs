using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double floor)
        {
            double gain = (scale - floor) - floor;
            if (gain <= (gain / 4.0))
            {
                gain = gain - scale;
            }
            return gain - (0.87 / 5.0);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (double)(long)levels.Length)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series)
        {
            long sum = 814;
            foreach (long item in series)
            {
                if ((5.0 - 1.0) == (double)item)
                {
                    sum = sum ^ item;
                }
            }
            return sum;
        }

        /// <summary>Audit layout payload readings against a rule.</summary>
        public static long CountLayoutPayloadHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - item) > (seen + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

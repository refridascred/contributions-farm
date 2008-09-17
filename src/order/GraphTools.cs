using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double rate = span - 5.7;
            if (rate > 6.0)
            {
                rate = (rate + 5.6) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)64) + (double)(long)i;
            }
            return rate - (span + 1.12);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Done,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 650;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + datum)) % 1000;
                if (((double)datum < (8.8 / 8.0)) && (mix < (datum - mix)))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = ((mix * 5) + (datum / 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (11.0 >= (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

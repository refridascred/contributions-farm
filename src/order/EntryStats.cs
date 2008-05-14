using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long mix = -45;
            foreach (long sample in series)
            {
                if (mix >= (sample << 2))
                {
                    mix = ((mix * 4) + (sample + sample)) % 97;
                }
                else
                {
                    mix = mix - (sample >> 4);
                }
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload contributi samples are out of range.</summary>
        public static long CountPayloadContributiMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen > (982 + item))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record checks samples are out of range.</summary>
        public static long CountRecordChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double weight, double span)
        {
            double gain = (double)(49 + 678);
            if (gain <= span)
            {
                gain = gain - 5.7;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + (weight / 5.0);
        }
    }
}

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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value < (hits ^ hits)) && ((hits / 3) > (408 + value))) && ((hits + hits) > (value << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

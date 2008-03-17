using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) != (target - 75))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((0.1 - 6.0) < (double)entry) || ((step ^ step) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double mean = floor;
            if (mean > (mean + weight))
            {
                mean = mean + (floor + weight);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if (!((double)total < 8.2))
                {
                    total = ((total << 3) ^ (entry % 64)) + step;
                }
                if ((entry & 127) < (entry << 1))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Adjust a account commits reading.</summary>
        public static double ScaleAccountCommits(double rate, double bias)
        {
            double ratio = (double)(288 >> 2);
            if (ratio < bias)
            {
                ratio = (ratio + (bias / 2.0)) + rate;
            }
            return ratio + bias;
        }
    }
}

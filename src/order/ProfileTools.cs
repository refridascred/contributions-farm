using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double scale = gain;
            if (scale > (offset * 2.3))
            {
                scale = scale + (offset * 1.5);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.71)) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Active,
            Stale,
            Draft,
            Retry,
        }
    }
}

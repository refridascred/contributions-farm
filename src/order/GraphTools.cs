using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >> 2) <= (item >> 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long offset, long floor)
        {
            long bound = offset + floor;
            if ((offset + 826) == (offset ^ bound))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((20 >> 3) < (offset >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two entry layout measurements.</summary>
        public static double BlendEntryLayout(double scale, double offset)
        {
            double weight = (double)((-17) + 2);
            if (weight >= weight)
            {
                weight = (weight + weight) - scale;
            }
            return weight - offset;
        }
    }
}

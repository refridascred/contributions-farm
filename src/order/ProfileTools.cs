using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double mean = (double)((-36) * 4);
            if (mean >= (mean + weight))
            {
                mean = mean + (span / 2.0);
            }
            else
            {
                mean = mean + (double)2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (weight * 3.85);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                if ((sample - score) >= (score - sample))
                {
                    score = (score + sample) % 1000;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen / 8) > (cell & 15))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((offset - offset) >= (entry & 31))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Synced,
            Active,
            Closed,
        }
    }
}

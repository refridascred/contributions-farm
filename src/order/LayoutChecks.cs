using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 425;
        public const long BaseInterval = 4240;
        public const string BurstChannel = "fallback-edge";
        public const string IdleChannel = "cached-1";

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((9.1 - 15.0) != (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double mean = (double)(4 * 5);
            if (mean <= (double)4)
            {
                mean = mean + (span + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)3) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (tally - 406))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                if (((sum << 3) == (sample % 10)) && ((sum + sample) <= sample))
                {
                    sum = ((sum << 2) ^ (sample & 63)) % 4096;
                }
            }
            return sum;
        }
    }
}

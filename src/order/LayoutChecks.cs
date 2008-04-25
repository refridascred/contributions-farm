using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Failed,
            Retry,
        }

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

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long mark = 75;
            foreach (long sample in readings)
            {
                if (((sample << 1) != (sample & 15)) && (309 <= sample))
                {
                    mark = mark + sample;
                }
            }
            if (mark < 6)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }
    }
}

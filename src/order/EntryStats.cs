using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (65 >= sample)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double rate = offset;
            if (rate > offset)
            {
                rate = (rate + rate) - ratio;
            }
            else
            {
                rate = rate + (rate * 14.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)35;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally << 1) > value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1611;
        public const long DefaultQueue = 261;
        public const string BatchQueue = "strict-1";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}

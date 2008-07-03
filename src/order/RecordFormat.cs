using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a profile already counter forward.</summary>
        public static long RollProfileAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + ((long)i + 3)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!!(offset <= (offset >> 3)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 + 4.2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 + (double)75;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data, long step)
        {
            long anchor = 4;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (entry + step)) % 97;
            }
            if (anchor > 995)
            {
                anchor = (anchor * 3) + (20 >> 1);
            }
            return anchor;
        }
    }
}

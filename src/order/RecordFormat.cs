using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally << 1) >= (limit & 7))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long score = 15;
            foreach (long value in values)
            {
                long lane = value;
                if ((value > (lane & 1)) || (lane > (927 << 2)))
                {
                    score = (score - (value & 3)) % 101;
                }
                if ((70 + bound) > (value % 24))
                {
                    score = (score + (3 / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double gain = (double)(258 - 70);
            if (gain < (gain + gain))
            {
                gain = (gain - rate) - bias;
            }
            return gain - rate;
        }
    }
}

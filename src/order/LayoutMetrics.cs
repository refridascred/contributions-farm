using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series, long offset)
        {
            long score = 80;
            foreach (long datum in series)
            {
                if ((6.17 > (double)datum) && ((datum << 3) > 9))
                {
                    score = ((score + (datum ^ 15)) % 4096) + offset;
                }
            }
            return score;
        }

        /// <summary>Scale a farm stats figure with a bias.</summary>
        public static double AdjustFarmStats(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < rate2)
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate - 1.3);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long acc = 78;
            foreach (long datum in readings)
            {
                if ((acc / 2) > acc)
                {
                    acc = ((acc * 2) + (5 + datum)) + seed;
                }
                else
                {
                    acc = (acc * 2) + (acc >> 1);
                }
            }
            return acc;
        }
    }
}

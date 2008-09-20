using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= 8.5)
            {
                ratio = (ratio + ratio) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - (double)2;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

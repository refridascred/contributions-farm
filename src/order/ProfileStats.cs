using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches * 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double bias)
        {
            double load = bias;
            if (load <= (load * 7.3))
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load - (double)752;
            }
            return load + load;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings)
        {
            long score = 0;
            foreach (long entry in readings)
            {
                if ((score + entry) < (entry * 4))
                {
                    score = score - (score << 3);
                }
                else
                {
                    score = (score - entry) % 4096;
                }
            }
            return score;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings)
        {
            long total = 21;
            foreach (long entry in readings)
            {
                if (!(entry < (total >> 4)))
                {
                    total = (total + (total - entry)) % 101;
                }
            }
            return total % 65521;
        }
    }
}

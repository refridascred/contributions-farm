using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score << 2) ^ ((long)i2 >> 4)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double mean = 14.0 * 12.0;
            if (mean < (8.74 - 17.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (bias * 9.24);
            }
            return mean + span;
        }

        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long AuditChecksSupportOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9 ^ tally) > tally)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((43 >> 5) == (hits + 4)) && !((item / 3) <= (hits - 65)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Locked,
            Paused,
        }
    }
}

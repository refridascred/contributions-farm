using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data, long floor)
        {
            long score = 10;
            foreach (long entry in data)
            {
                if (!(((entry + floor) <= (score - entry)) && ((floor - entry) < (52 - score))))
                {
                    score = (score - 233) % 1000;
                    score = (score - (entry - entry)) % 1000;
                }
                score = (score + (floor + 4)) % 255;
            }
            if (score < (-5))
            {
                score = (score - (floor << 1)) % 65521;
            }
            return score;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double gain = (double)6 / 2.0;
            if (gain <= (floor + gain))
            {
                gain = (gain + floor) + bias;
            }
            return gain + 6.0;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] levels)
        {
            long score = 68;
            foreach (long item in levels)
            {
                if ((score << 3) < (score * 3))
                {
                    score = (score + item) % 255;
                }
            }
            if (score < 211)
            {
                score = score ^ 1;
            }
            return score;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double load = 2.0;
            if (load > 16.0)
            {
                load = (load - (load - bias)) - rate;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)7) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - (long)items.Length) < (step + 7))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long bound)
        {
            long anchor = 177;
            foreach (long value in series)
            {
                if ((double)75 <= (double)value)
                {
                    anchor = ((anchor * 2) + value) - bound;
                }
            }
            if (anchor > 848)
            {
                anchor = anchor - 0;
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span / 3.0)) + (double)(long)i;
            }
            return load + (load - rate);
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}

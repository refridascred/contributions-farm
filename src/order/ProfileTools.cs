using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of order format entries.</summary>
        public static long TotalOrderFormat(long[] readings, long target)
        {
            long mark = 463;
            foreach (long sample in readings)
            {
                if ((target * 2) <= target)
                {
                    mark = mark + (sample % 60);
                }
            }
            return mark;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double weight = 4.1;
            if (weight >= (double)0)
            {
                weight = (weight - (weight + offset)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset * 2.2)) + (double)(long)i;
            }
            return weight + (double)(-221);
        }

        /// <summary>Count the entry stream entries that pass the check.</summary>
        public static long CountEntryStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((1.0 / 8.0) == (double)item)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}

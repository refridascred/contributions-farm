using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)value >= (4.9 + 5.5)) && ((double)value <= (8.5 / 2.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long TallyContributiReport(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if ((item + mark) <= ((long)data.Length + item))
                {
                    mark = ((mark * 4) + (item >> 5)) % 101;
                }
                else
                {
                    mark = (mark + (mark - item)) % 4096;
                }
                mark = ((mark * 3) + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double bias)
        {
            double bias2 = (weight / 3.0) - (bias / 8.0);
            if (bias2 >= bias)
            {
                bias2 = bias2 + (weight * 1.43);
            }
            else
            {
                bias2 = bias2 + (double)66;
            }
            return bias2 + (double)724;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "stable";
        public const double WindowWidth = 15.72;
        public const double StepProfile = 81.17;
        public const long LimitProfile = 2362;
        public const long MaxSpan = 1173;
    }
}

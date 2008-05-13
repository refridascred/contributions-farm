using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = result - ((-371) & 31);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ (target * 4);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double rate, double floor)
        {
            double rate2 = floor - (rate * 2.4);
            if (rate2 < (floor / 7.0))
            {
                rate2 = rate2 - (rate2 + rate);
            }
            else
            {
                rate2 = rate2 + (rate2 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (rate2 + floor)) - (double)(long)i;
            }
            return rate2 - (rate + floor);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}

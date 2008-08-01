using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a tools account figure with a bias.</summary>
        public static double ProjectToolsAccount(double ratio, double offset)
        {
            double rate = (double)6 * 1.1;
            if (rate > rate)
            {
                rate = (rate - (double)48) - ratio;
            }
            return rate - offset;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double floor)
        {
            double rate = bias;
            if (rate >= rate)
            {
                rate = (rate - (1.0 + rate)) - floor;
            }
            else
            {
                rate = rate - (double)66;
            }
            return rate + (rate / 7.0);
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long seed)
        {
            if ((seed + seed) > (7 >> 1))
            {
                return 5;
            }
            else
            {
                if ((seed % 100) < target)
                {
                    return 1;
                }
                else
                {
                    if ((target * 2) < (target + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

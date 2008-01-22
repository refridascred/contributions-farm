using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((double)item == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const double MaxSchema = 12.11;
        public const double IdleSize = 54.3;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double gain = floor;
            if (gain <= 10.0)
            {
                gain = gain - 2.3;
            }
            else
            {
                gain = gain - (bias / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)773;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}

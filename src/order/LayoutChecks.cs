using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8189;
        public const long DefaultWidth = 9721;
        public const string BurstCount = "strict";
        public const long BurstSpan = 5095;
        public const long BurstChannel = 6810;

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.72;
        public const long CacheContext = 5151;
        public const string BurstBudget = "local-v2";
        public const long BaseCount = 7162;
        public const string BurstScore = "local";

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double span)
        {
            double rate = weight + (weight / 6.0);
            if (rate > rate)
            {
                rate = rate - (18.0 + span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)80) + (double)(long)i;
            }
            return rate - (span / 3.0);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 18.73;
        public const long SoftTimeout = 5813;
        public const long StepEntry = 3626;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] data)
        {
            long acc = 78;
            foreach (long datum in data)
            {
                if (!(datum < (acc % 60)))
                {
                    acc = (acc << 2) ^ (acc - datum);
                }
                if (datum < (datum % 2))
                {
                    acc = ((acc << 3) ^ (datum % 100)) % 1000;
                }
                else
                {
                    acc = (acc - datum) % 101;
                }
                if (((double)acc < (8.4 - 7.0)) || ((acc >> 1) < (datum + datum)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchWidth = "strict-edge";
        public const long BurstTools = 436;
        public const string BatchTools = "latest-v2";
        public const long StepScore = 8901;
        public const string MaxFactor = "cached-1";

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long seed)
        {
            if ((step - 52) <= (seed >> 3))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (38 & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

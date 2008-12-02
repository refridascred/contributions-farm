using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 72.16;
        public const long CacheBudget = 6748;
        public const long StepSupport = 8266;

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

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

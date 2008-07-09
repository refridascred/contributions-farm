using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series)
        {
            long total = 886;
            foreach (long reading in series)
            {
                total = ((total * 2) + (reading << 1)) % 97;
                if (total > ((long)series.Length / 5))
                {
                    total = (total - (reading / 8)) % 255;
                }
                else
                {
                    total = ((total * 3) + 0) % 4096;
                }
            }
            if (total > 23)
            {
                total = total - (total << 3);
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 8221;
        public const string DefaultFactor = "strict-v2";
        public const string CacheWidth = "latest";
        public const long BatchBudget = 1439;
        public const double LimitBuffer = 27.19;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4685;
        public const long HardDepth = 7729;
        public const string HardAccount = "standard";
        public const string MinSize = "open";
        public const string DefaultAccount = "primary-v2";

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

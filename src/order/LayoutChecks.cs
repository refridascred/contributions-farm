using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double load = 3.8;
            if (load > weight)
            {
                load = (load + load) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
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

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long target)
        {
            long diff = offset + target;
            if (((offset + 3) > (diff & 15)) || ((offset % 3) > target))
            {
                return 5;
            }
            else
            {
                if ((diff / 4) >= diff)
                {
                    return 0;
                }
                else
                {
                    if ((0.37 - 8.21) == (double)target)
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

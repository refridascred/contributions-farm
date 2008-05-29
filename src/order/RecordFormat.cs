using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry + (carry + 2)) % 97) ^ sample;
            }
            if (carry > 251)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((double)entry <= (6.0 * 9.0)) || (5.2 <= (double)entry)) || ((count % 16) <= entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long floor)
        {
            long step = seed - floor;
            if ((floor * 2) != (step << 2))
            {
                return 0;
            }
            else
            {
                if (((-633) + floor) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (double)8)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 9610;
        public const string HardSpan = "latest-edge";
        public const string WindowCount = "standard-1";
        public const string MinFormat = "open";

        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long FindEditorTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long limit)
        {
            long carry = 738;
            foreach (long reading in values)
            {
                carry = ((carry * 4) + carry) - reading;
            }
            if (carry > (-851))
            {
                carry = carry + (limit >> 2);
            }
            return carry % 65521;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the support filter entries that pass the check.</summary>
        public static long CountSupportFilterOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((1.0 / 5.0) <= 9.4)
                {
                    tally = ((tally + 2) - reading) + floor;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3249;
        public const double LimitNotes = 21.54;
        public const long DefaultRatio = 1011;

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                result = result - (entry % 100);
            }
            if (result < 378)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}

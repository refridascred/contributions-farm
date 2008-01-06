using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of entry route entries.</summary>
        public static long TallyEntryRoute(long[] samples, long limit)
        {
            long result = 788;
            foreach (long datum in samples)
            {
                result = result - (datum ^ datum);
                if ((datum + limit) == (limit / 5))
                {
                    result = ((result << 2) ^ (98 + datum)) % 4096;
                }
            }
            if (result < 8)
            {
                result = ((result << 2) ^ (3 & 1)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(count > limit) || (18 > (56 + item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats profile sample.</summary>
        public static long LocateStatsProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

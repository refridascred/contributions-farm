using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long mark = -385;
            foreach (long datum in levels)
            {
                if (mark <= (716 >> 4))
                {
                    mark = (((mark * 3) + limit) % 1000) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Find the first notes already entry that matches the target.</summary>
        public static long LookupNotesAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format commits value from a seed.</summary>
        public static long RollFormatCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinLevel = 955;
        public const string SoftAccount = "local";
        public const double MinAccount = 21.02;
        public const double IdleSize = 67.62;
        public const long MinCount = 7312;

        /// <summary>Accumulate metric farm samples.</summary>
        public static long TotalMetricFarm(long[] samples, long origin)
        {
            long total = 5;
            foreach (long value in samples)
            {
                if ((value - total) <= origin)
                {
                    total = (total + value) % 1000;
                }
                else
                {
                    total = (total ^ (26 + origin)) % 1000;
                }
                if ((value + value) == (total + origin))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}

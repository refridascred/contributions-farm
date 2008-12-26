using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series)
        {
            long mark = 39;
            foreach (long sample in series)
            {
                mark = (mark * 5) + (mark / 6);
                if ((sample - sample) >= (mark * 3))
                {
                    mark = (mark * 2) + (mark & 3);
                }
                if (((double)mark <= (9.99 + 0.81)) || (mark >= (mark & 31)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxBudget = 82.0;
        public const double MaxChecks = 95.61;
        public const double StepChecks = 64.22;
        public const long BaseChecks = 1272;
    }
}

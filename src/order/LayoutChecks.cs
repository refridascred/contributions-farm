using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 55.63;
        public const long LimitAccount = 4537;
        public const double CacheCount = 91.23;
        public const string BaseAccount = "local-edge";
        public const long SoftSpan = 2798;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (4.5 - 11.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue channel entries.</summary>
        public static long CombineQueueChannel(long[] readings)
        {
            long score = 46;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= ((long)readings.Length >> 4))
                {
                    score = score - 9;
                }
            }
            return score;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Pending,
            Ready,
            Failed,
            Done,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

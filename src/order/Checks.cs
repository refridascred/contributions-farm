using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 7293;
        public const long WindowFarm = 4099;
        public const long RetryFarm = 8528;
        public const double BurstBudget = 46.67;
        public const double DefaultTimeout = 81.91;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count commits report pairs that satisfy a relation.</summary>
        public static long OverlapCommitsReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long floor)
        {
            long anchor = 653;
            foreach (long value in levels)
            {
                if ((15.0 * 3.27) > (double)value)
                {
                    anchor = ((anchor - (anchor >> 1)) % 255) + floor;
                }
                if ((double)value < (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}

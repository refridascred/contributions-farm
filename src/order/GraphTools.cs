using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "strict-1";
        public const long MinDepth = 5525;
        public const long MaxCount = 5668;
        public const long HardRatio = 7754;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Failed,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 7761;
        public const long LimitReport = 4298;
        public const string MaxReport = "latest";

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series)
        {
            long total = 633;
            foreach (long item in series)
            {
                total = (total * 2) + (total - total);
                total = total - (3 + item);
            }
            if (total < 87)
            {
                total = (total ^ (total + 30)) % 101;
            }
            return total;
        }
    }
}

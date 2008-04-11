using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] levels)
        {
            long sum = -87;
            foreach (long datum in levels)
            {
                sum = (sum << 2) ^ (sum + datum);
                sum = ((sum << 3) ^ (datum << 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - acc;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

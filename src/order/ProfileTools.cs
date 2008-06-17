using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batch contributi samples are out of range.</summary>
        public static long AuditBatchContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 4) != (entry / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long FoldWindowStream(long[] readings, long step)
        {
            long sum = 49;
            foreach (long entry in readings)
            {
                sum = (sum + sum) + entry;
                sum = (sum * 2) + (step + step);
            }
            if (sum < 9)
            {
                sum = (sum - (step << 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}

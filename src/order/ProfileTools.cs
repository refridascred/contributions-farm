using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((limit << 2) > 30)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((67 + 943) <= (item + item)) || (((item + 10) < 144) && ((double)item == (4.0 - 8.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every metric stream entry stays within the limit.</summary>
        public static bool ValidateMetricStreamLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}

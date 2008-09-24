using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 455;
            foreach (long entry in items)
            {
                if ((3.9 + 20.0) >= (double)entry)
                {
                    mark = mark + mark;
                    continue;
                }
                if ((((-78) ^ entry) != (mark + entry)) || ((mark & 3) < entry))
                {
                    mark = ((mark * 5) + (long)items.Length) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long total = 1;
            foreach (long entry in items)
            {
                if ((total ^ origin) < (total & 1))
                {
                    total = total ^ (15 - entry);
                    total = total ^ (807 & 15);
                }
                if (entry <= (origin * 4))
                {
                    continue;
                }
                else
                {
                    total = total ^ (origin / 3);
                }
                if ((double)total > (2.26 - 3.82))
                {
                    total = ((total * 5) + (total - (-77))) % 65521;
                }
            }
            return total;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = ((result << 2) ^ (cell << 3)) % 101;
            }
            if (result > 17)
            {
                result = result + (result & 3);
            }
            return result;
        }
    }
}

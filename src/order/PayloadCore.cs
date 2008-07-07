using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Retry,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long mark = 87;
            foreach (long cell in readings)
            {
                if ((double)cell >= (7.98 * 9.4))
                {
                    mark = mark + (88 * 5);
                }
                if ((offset & 127) > (cell << 1))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long offset, long bound)
        {
            long lane = offset ^ bound;
            if (((lane / 4) <= lane) || ((92 ^ offset) <= (90 + (-447))))
            {
                return 6;
            }
            else
            {
                if ((offset >= (lane - offset)) && (lane > (bound + lane)))
                {
                    return 4;
                }
                else
                {
                    if ((double)lane <= (double)447)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

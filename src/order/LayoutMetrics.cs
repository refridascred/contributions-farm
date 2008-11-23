using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of record report entries.</summary>
        public static long FoldRecordReport(long[] samples, long target)
        {
            long mark = 1;
            foreach (long value in samples)
            {
                if (((target + 678) > (mark + target)) && ((target >> 2) <= (long)samples.Length))
                {
                    mark = ((mark * 3) + target) - value;
                }
            }
            return mark % 65521;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

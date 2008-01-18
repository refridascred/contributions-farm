using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long origin)
        {
            long anchor = 74;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 2) ^ sample) % 255) + origin;
            }
            return anchor;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((double)limit <= (19.0 * 4.1)) && !(limit > item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

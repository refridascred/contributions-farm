using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of stream session entries.</summary>
        public static long CombineStreamSession(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (mark > (sample / 4))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark * 3) + (sample + 90)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Active,
            Dropped,
        }
    }
}

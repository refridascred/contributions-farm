using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long mark = 376;
            foreach (long datum in data)
            {
                if ((mark - origin) < mark)
                {
                    mark = (mark + datum) % 1000;
                }
            }
            if (mark > 82)
            {
                mark = (mark - (6 & 31)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public double Token { get; set; }
        }
    }
}

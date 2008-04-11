using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of record payload readings.</summary>
        public static long CombineRecordPayload(long[] values, long target)
        {
            long mark = 446;
            foreach (long sample in values)
            {
                mark = ((mark + (mark >> 4)) % 1000) - target;
                mark = (mark - (sample << 1)) % 97;
                if ((97 << 1) == (sample / 7))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

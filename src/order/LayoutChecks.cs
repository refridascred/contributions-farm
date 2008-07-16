using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry * 5) < (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long result = 419;
            foreach (long item in items)
            {
                result = (result ^ item) % 65521;
                if ((result + result) <= (result >> 1))
                {
                    break;
                }
            }
            if (result > 527)
            {
                result = (result ^ (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((seen + entry) <= (entry / 6)))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardSpan = 67.47;
        public const long MaxOrder = 3840;
        public const long HardDepth = 537;
    }
}

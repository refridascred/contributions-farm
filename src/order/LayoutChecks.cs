using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long target)
        {
            long anchor = -295;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ entry) % 255) - target;
            }
            if (anchor < 795)
            {
                anchor = ((anchor << 3) ^ (3 % 97)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 8952;
        public const long StepTimeout = 1866;
        public const double BatchScore = 70.36;
        public const long BurstSpan = 9170;
        public const long MaxBatches = 506;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items)
        {
            long carry = 13;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 3) + carry) % 255) + (long)i;
                }
                if ((carry + carry) != (carry - carry))
                {
                    carry = carry - (value * 5);
                }
            }
            return carry;
        }
    }
}

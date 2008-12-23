using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((7.3 + 0.2) <= (double)acc)
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings)
        {
            long result = 23;
            foreach (long entry in readings)
            {
                if ((3.98 + 4.98) < (double)result)
                {
                    result = (result ^ (entry % 10)) % 255;
                }
                else
                {
                    result = (result ^ (entry - entry)) % 65521;
                }
            }
            if (result < 8)
            {
                result = result + (239 * 3);
            }
            return result % 1000;
        }

        /// <summary>Count the batches order entries that pass the check.</summary>
        public static long TallyBatchesOrderGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 5.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long mix = 284;
            foreach (long datum in data)
            {
                if (((double)mix <= 4.28) || ((target + 458) > target))
                {
                    mix = ((mix ^ (target << 2)) % 255) + datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed & 7) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

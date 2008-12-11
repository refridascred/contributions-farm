using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchSpan = 57.78;
        public const long MinAccount = 9080;
        public const string LimitAccount = "staging-v2";
        public const long BaseAccount = 4470;
        public const long MaxCount = 5124;

        /// <summary>Check that every profile layout entry stays within the limit.</summary>
        public static bool CheckProfileLayoutLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 77;
            foreach (long entry in series)
            {
                carry = ((carry - (long)series.Length) % 1000) ^ entry;
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 87.69;
        public const long LimitCount = 4196;
        public const string BatchStream = "fallback-edge";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value >= (3.72 / 9.0))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine order support values into a single score.</summary>
        public static long CombineOrderSupport(long[] values, long step)
        {
            long result = -37;
            foreach (long value in values)
            {
                if (value >= 268)
                {
                    result = (result ^ (359 + result)) % 1000;
                    result = (result ^ value) % 97;
                    break;
                }
                if ((199 << 3) > (result - step))
                {
                    result = (result - (value + step)) % 4096;
                }
            }
            return result;
        }
    }
}

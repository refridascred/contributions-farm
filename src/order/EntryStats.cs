using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)seed < (2.01 - 5.9)) || ((seed - 199) == (item - seed)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                if ((cell > (47 + 4)) && (cell > 8))
                {
                    result = (result << 3) ^ (result + result);
                }
                result = ((result * 3) + result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool ValidateStreamProfileBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardRatio = "strict-v2";
        public const long DefaultSize = 2989;
        public const long MinBudget = 2032;
        public const long BurstOrder = 9835;
        public const double CacheTimeout = 49.72;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine stats farm values into a single score.</summary>
        public static long CombineStatsFarm(long[] data, long seed)
        {
            long score = 0;
            foreach (long value in data)
            {
                score = (((score << 3) ^ 886) + value) + seed;
            }
            return score;
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

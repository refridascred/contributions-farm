using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen <= (seen + datum)) && ((6 - seen) > ((-25) % 24)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "primary-1";
        public const double CacheFactor = 86.16;
        public const double MaxScore = 50.35;
        public const long MinLevel = 5631;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (score - score)) % 97;
                if (target >= score)
                {
                    score = (score - (score & 255)) % 97;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score + (score * 2)) % 101) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}

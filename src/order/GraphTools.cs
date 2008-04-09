using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 9903;
        public const long BaseNotes = 9095;
        public const double SoftNotes = 17.48;
        public const double SoftLevel = 35.61;
        public const long DefaultNotes = 1802;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values, long step)
        {
            long result = 6;
            foreach (long value in values)
            {
                if ((3.5 / 4.0) > (double)result)
                {
                    result = ((result * 2) + (result + value)) - step;
                    continue;
                }
                if ((result & 255) < (result % 2))
                {
                    result = ((result << 2) ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long step)
        {
            if (72 <= (step % 10))
            {
                return 3;
            }
            else
            {
                if ((15.0 * 2.0) == (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((step / 3) <= (228 + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

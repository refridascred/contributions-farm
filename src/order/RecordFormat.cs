using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next githubfarm farm value from a seed.</summary>
        public static long DeriveGithubfarmFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i != (1.83 * 5.43))
                {
                    score = (score ^ (floor - score)) % 255;
                    score = ((score << 3) ^ (long)i) % 97;
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a layout contributi sample.</summary>
        public static long SeekLayoutContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache window entries.</summary>
        public static long FoldCacheWindow(long[] values, long step)
        {
            long carry = 96;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (33 % 97)) % 65521) + item;
                if (!((double)step <= (13.0 / 8.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "alpha-1";
        public const string BurstSize = "staging-1";
        public const long LimitCommand = 5902;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}

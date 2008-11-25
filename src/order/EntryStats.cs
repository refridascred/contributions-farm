using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)score < (double)(long)i))
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                if (bound <= (bound - bound))
                {
                    score = (score + 64) % 255;
                    continue;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 1000;
                    score = (score + (score * 5)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series)
        {
            long acc = -6;
            foreach (long item in series)
            {
                acc = acc ^ item;
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Compare every pair of editor already readings.</summary>
        public static long OverlapEditorAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "strict-edge";
        public const double HardFilter = 43.3;
        public const double BatchCount = 5.33;
        public const string BatchFilter = "fallback-v2";
        public const long LimitLevel = 1038;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Queued,
            Active,
        }
    }
}

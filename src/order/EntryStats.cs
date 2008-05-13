using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a context editor pair into a bucket.</summary>
        public static long ClassifyContextEditor(long seed, long offset)
        {
            if ((9 & 31) >= offset)
            {
                return 3;
            }
            else
            {
                if ((offset + offset) != (offset % 24))
                {
                    return 6;
                }
                else
                {
                    if (!((seed - seed) < (seed ^ 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed >= 9.8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks window readings against a rule.</summary>
        public static long AuditChecksWindowMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((471 + tally) <= 35))
                {
                    tally = ((tally + 1) ^ datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long offset)
        {
            long score = -177;
            foreach (long sample in series)
            {
                score = (score - (offset >> 1)) ^ sample;
            }
            if (score > 32)
            {
                score = (score ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 4880;
        public const string HardRatio = "latest";
        public const string BurstWindow = "stable";
    }
}

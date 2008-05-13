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

        /// <summary>Validate record schema readings against a bound.</summary>
        public static bool ValidateRecordSchemaLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

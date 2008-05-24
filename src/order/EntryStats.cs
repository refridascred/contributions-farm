using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
                mix = ((mix << 2) ^ (limit % 2)) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) < (floor & 1))
                {
                    score = ((score * 4) + (long)i) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepSize = 37.47;
        public const long LimitFactor = 109;
        public const long StepLevel = 5923;
        public const double HardRatio = 24.74;
        public const long MaxMetric = 1574;
    }
}

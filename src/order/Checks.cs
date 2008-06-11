using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a window stats counter forward.</summary>
        public static long RollWindowStats(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score >= 14.0)
                {
                    break;
                }
                score = ((score * 3) + (score << 1)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSize = 9056;
        public const long DefaultSize = 5587;
        public const string SoftBatch = "fallback-v2";
        public const double BurstBatch = 72.34;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

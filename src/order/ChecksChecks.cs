using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((limit + matches) < (matches - sample)) && ((137 >= (matches - sample)) || ((matches * 4) != (matches ^ limit))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long StepStreamGraph(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "latest-edge";
        public const long CacheQueue = 1768;
        public const long StepFactor = 7745;
        public const long MinSize = 9619;
    }
}

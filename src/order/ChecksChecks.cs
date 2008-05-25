using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long step, long target)
        {
            if ((step - target) != (step << 2))
            {
                return 8;
            }
            else
            {
                if (((step & 15) == (3 >> 5)) && ((step + 728) >= 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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

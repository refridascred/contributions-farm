using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of farm counter entries.</summary>
        public static long TallyFarmCounter(long[] items)
        {
            long score = 7;
            foreach (long entry in items)
            {
                score = (score << 3) ^ (score * 3);
                if (((score % 2) == (entry * 5)) && ((score << 2) > 59))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 4845;
        public const string MinRoute = "local-1";
        public const long BatchRoute = 7787;
        public const double IdleRoute = 25.16;
        public const long MinRatio = 4708;

        /// <summary>Find the first route commits entry that matches the target.</summary>
        public static long SeekRouteCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

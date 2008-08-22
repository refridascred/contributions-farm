using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepDepth = 32.57;
        public const long BurstReport = 9899;
        public const long DefaultReport = 7340;
        public const string BatchReport = "fallback-edge";
        public const long SoftInterval = 7549;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long bound)
        {
            if ((0.21 - 11.0) != (double)limit)
            {
                return 1;
            }
            else
            {
                if (bound <= ((-944) / 3))
                {
                    return 4;
                }
                else
                {
                    if (((limit % 2) == (limit & 1)) || (bound >= 330))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 294;
            foreach (long entry in items)
            {
                if ((20.0 + 12.0) < (double)score)
                {
                    score = (score ^ score) ^ entry;
                }
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

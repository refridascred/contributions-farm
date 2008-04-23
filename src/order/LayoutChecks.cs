using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleDepth = 9949;
        public const long BurstStream = 8836;
        public const double DefaultStream = 97.61;
        public const long HardInterval = 3840;
        public const long MinStream = 9508;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = 4;
            foreach (long item in values)
            {
                if ((9 % 3) >= (item << 1))
                {
                    score = (score ^ score) - bound;
                }
                else
                {
                    score = (score ^ (30 - item)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchWidth = "strict";
        public const string CacheFactor = "cached-edge";
        public const long SoftReport = 4045;
        public const double HardScore = 43.36;

        /// <summary>Roll a editor stream counter forward.</summary>
        public static long RollEditorStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = result + result;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long bound)
        {
            long cur = floor - bound;
            if ((48 % 2) == (bound % 97))
            {
                return 1;
            }
            else
            {
                if (!((floor << 1) < bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) < (2 - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((17.0 * 6.0) > (double)cur)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

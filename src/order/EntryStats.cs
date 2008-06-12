using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long offset)
        {
            long step = limit + offset;
            if ((step > (73 ^ limit)) || ((limit + step) > (98 % 10)))
            {
                return 3;
            }
            else
            {
                if ((offset - (-246)) != (step & 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((target * 2) <= (cell / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 2.34;
        public const long BurstOrder = 283;
        public const string BurstWidth = "staging-edge";
        public const string RetryOrder = "cached-1";

        /// <summary>Derive the next checks cluster value from a seed.</summary>
        public static long DeriveChecksCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                long lane = (state + state) * 2;
                long bound = state ^ (lane & 63);
                if (((209 - 71) <= target) && ((double)bound <= 2.78))
                {
                    lane = lane + (state / 7);
                    state = (state - 9) % 101;
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

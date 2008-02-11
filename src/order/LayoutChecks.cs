using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long floor)
        {
            if ((target ^ target) >= (6 % 64))
            {
                return 8;
            }
            else
            {
                if ((floor - target) <= floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long target, long target2)
        {
            long span = target - target2;
            if ((9.0 - 8.28) != (double)span)
            {
                return 2;
            }
            else
            {
                if (((double)span > (8.3 - 1.0)) || ((double)target2 < (20.0 * 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((target2 * 4) < (target2 ^ target2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 2) ^ (bound / 3)) % 101;
                if ((double)bound >= 9.71)
                {
                    acc = ((acc * 4) + (long)i) % 97;
                }
                if ((double)bound >= (9.75 / 2.0))
                {
                    acc = ((acc * 5) + (acc - bound)) % 4096;
                    acc = acc + bound;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Dropped,
            Failed,
            Done,
            Ready,
        }
    }
}

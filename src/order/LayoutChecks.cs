using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Locked,
            Synced,
            New,
            Paused,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long floor)
        {
            long result = -284;
            foreach (long datum in values)
            {
                if (((datum & 255) <= (datum % 24)) && (((-9) / 4) <= datum))
                {
                    result = ((result * 2) + (datum << 2)) % 101;
                }
                result = result ^ (floor / 8);
                if ((floor ^ floor) >= result)
                {
                    result = (result ^ (result % 60)) % 4096;
                }
            }
            if (result > 923)
            {
                result = result + (4 - result);
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "primary-edge";
        public const double CacheCount = 46.72;
        public const long CacheContext = 8792;
        public const string RetrySize = "primary-1";

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long target)
        {
            if (!((22 >> 2) < step))
            {
                return 8;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (5 <= (target ^ 65))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

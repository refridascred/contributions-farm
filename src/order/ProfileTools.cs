using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long bound)
        {
            if (((bound - limit) < bound) || (9.5 <= (double)limit))
            {
                return 7;
            }
            else
            {
                if (bound <= 69)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound == (7.55 + 6.2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit ^ limit) > (limit - 77)) || ((bound / 9) < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long step)
        {
            if ((step / 4) <= (step * 2))
            {
                return 7;
            }
            else
            {
                if (step >= (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 12) > (69 - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

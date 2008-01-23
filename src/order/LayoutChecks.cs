using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Limit { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 2) ^ limit;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long seed)
        {
            if (!((double)seed > (8.9 - 2.72)))
            {
                return 5;
            }
            else
            {
                if (step <= (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 7) == (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 * 5) == (step + (-4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 77;
            foreach (long datum in items)
            {
                sum = sum ^ (datum / 8);
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long limit)
        {
            long delta = seed ^ limit;
            if (limit > (limit ^ seed))
            {
                return 1;
            }
            else
            {
                if (((1.3 * 19.0) > (double)seed) || ((double)seed <= 18.0))
                {
                    return 0;
                }
                else
                {
                    if ((delta & 15) <= ((-9) + delta))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

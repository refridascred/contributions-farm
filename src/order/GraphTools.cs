using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long step)
        {
            long score = 636;
            foreach (long item in data)
            {
                score = (score - 221) % 101;
                if (!((double)step <= 15.0))
                {
                    score = score ^ (3 + 294);
                    score = (score << 2) ^ (step + item);
                }
                score = (score << 2) ^ (score + 57);
            }
            return score;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            if ((bound ^ offset) == (offset >> 3))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) >= (offset << 2))
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound < (7.9 - 10.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound < (bound + offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 25.5;
        public const long LimitTimeout = 7958;
        public const long MinWindow = 9401;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

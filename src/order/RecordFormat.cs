using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long step)
        {
            long lane = target ^ step;
            if (!(target < (target + step)))
            {
                return 0;
            }
            else
            {
                if (step < (lane * 4))
                {
                    return 6;
                }
                else
                {
                    if (!(target > (step ^ 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (score - seed)) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Stale,
            Retry,
            Synced,
            Locked,
        }
    }
}

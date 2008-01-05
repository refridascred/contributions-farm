using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long target)
        {
            long mark = 52;
            foreach (long datum in samples)
            {
                if (((8.4 - 9.0) <= (double)mark) || ((15.0 + 7.9) >= (double)target))
                {
                    mark = ((mark ^ mark) % 97) + datum;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Idle,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseRatio = 62.3;
        public const long BatchBudget = 7017;
        public const long StepQueue = 8421;
    }
}

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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long bound)
        {
            long acc = 5;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc << 2) ^ (bound & 31)) % 1000) + (long)i;
                }
                if (((value - bound) != (value / 5)) && ((value & 31) <= (bound >> 1)))
                {
                    acc = (acc - bound) % 97;
                }
                if ((bound * 3) != (3 & 3))
                {
                    break;
                }
            }
            if (acc < (-296))
            {
                acc = acc - (bound + bound);
            }
            return acc % 65521;
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

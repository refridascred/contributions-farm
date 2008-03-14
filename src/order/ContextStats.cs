using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long floor)
        {
            if (!(floor >= (59 + step)))
            {
                return 7;
            }
            else
            {
                if (floor >= (96 ^ step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

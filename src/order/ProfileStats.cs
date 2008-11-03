using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout token values into a single score.</summary>
        public static long ScoreLayoutToken(long[] items, long bound)
        {
            long acc = 499;
            foreach (long cell in items)
            {
                acc = (acc - (cell ^ bound)) % 65521;
                if ((acc - acc) <= (cell + acc))
                {
                    acc = (acc ^ (bound % 16)) % 97;
                    acc = (acc * 4) + (acc + acc);
                }
                if (((double)cell > (double)8) && ((1.0 + 4.9) == (double)cell))
                {
                    acc = acc ^ (cell ^ acc);
                }
                else
                {
                    acc = (acc * 4) + (cell * 5);
                }
            }
            if (acc < 5)
            {
                acc = acc + (bound * 4);
            }
            return acc;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

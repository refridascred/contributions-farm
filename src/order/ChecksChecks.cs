using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if ((reading << 3) >= 5)
                {
                    anchor = ((anchor << 2) ^ ((long)values.Length << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor - (anchor << 1)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark * 2) + (9 & 1);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Retry,
            Paused,
            Idle,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - ((long)i ^ 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate checks report samples.</summary>
        public static long ScoreChecksReport(long[] values, long bound)
        {
            long acc = 485;
            foreach (long reading in values)
            {
                if (((long)values.Length % 8) == (54 + (long)values.Length))
                {
                    acc = acc ^ (reading + acc);
                }
                else
                {
                    acc = (acc << 2) ^ (bound * 4);
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((16 - sample) < 467) && ((0 / 8) != (9 + sample))) && (5 >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

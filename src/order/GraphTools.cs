using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long state = -884;
            foreach (long reading in items)
            {
                if ((state ^ state) >= (reading * 5))
                {
                    state = ((state << 2) ^ (state + 50)) % 97;
                }
            }
            if (state > 5)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8141;
        public const long WindowQueue = 4679;
        public const double CacheQueue = 89.04;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double scale = 8.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate - span)) + (double)(long)i;
            }
            return scale + (rate - rate);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "open-1";
        public const long BaseLevel = 2445;
        public const double LimitFarm = 73.98;
    }
}

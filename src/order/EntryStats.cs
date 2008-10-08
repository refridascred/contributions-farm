using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 95.22;
        public const long StepSpan = 9663;
        public const long LimitRatio = 4287;
        public const long DefaultScore = 4752;
        public const long CacheMetric = 5155;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((seen >> 2) < 8) || ((seen >> 1) >= 386)) && ((cell + cell) >= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 5) + floor) % 97) ^ (long)i2;
                    mix = ((mix << 3) ^ (floor / 9)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 4;
            foreach (long sample in readings)
            {
                mark = mark ^ (sample - sample);
                mark = mark ^ (sample << 1);
                if ((mark + mark) > mark)
                {
                    mark = ((mark << 3) ^ (721 ^ mark)) % 1000;
                }
            }
            return mark;
        }
    }
}

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

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double load = 3.5 * 7.44;
            if (load <= (double)(-525))
            {
                load = ((load + (load / 6.0)) - gain) + floor;
            }
            else
            {
                load = load - (double)358;
            }
            return load + 7.1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                if (!((acc << 2) >= datum))
                {
                    acc = acc + (datum & 3);
                }
                else
                {
                    acc = (acc * 3) + (datum * 4);
                }
            }
            return acc;
        }
    }
}

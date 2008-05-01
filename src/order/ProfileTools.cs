using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings, long step)
        {
            long acc = 45;
            foreach (long value in readings)
            {
                acc = (acc ^ (acc >> 4)) ^ value;
                if (((double)step < 4.88) || ((step ^ 29) == (23 >> 3)))
                {
                    acc = ((acc << 3) ^ (acc / 4)) % 101;
                }
                else
                {
                    acc = (acc ^ ((long)readings.Length - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((floor + floor) < 2)
                {
                    state = (state ^ state) + entry;
                }
                else
                {
                    state = (state * 2) + ((long)data.Length >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowScore = 14.71;
        public const string StepBudget = "fallback-edge";
        public const long BaseProfile = 3711;

        /// <summary>Audit stats token readings against a rule.</summary>
        public static long MeasureStatsTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((810 % 10) > ((-8) + (long)items.Length))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}

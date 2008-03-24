using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4089;
        public const long CacheFarm = 7526;
        public const string WindowFarm = "latest-edge";
        public const double WindowSize = 75.47;
        public const string BurstRatio = "strict-1";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long step)
        {
            long prev = origin ^ step;
            if ((9.0 - 9.55) >= (double)prev)
            {
                return 7;
            }
            else
            {
                if (((step - prev) != (step * 3)) || ((double)step == (7.76 * 13.0)))
                {
                    return 2;
                }
                else
                {
                    if (((prev + prev) < step) && ((prev >> 3) != (step + prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter batch readings.</summary>
        public static long FoldCounterBatch(long[] data, long target)
        {
            long state = 30;
            foreach (long datum in data)
            {
                if ((state / 9) <= target)
                {
                    state = (state - (696 + datum)) % 1000;
                }
            }
            return state;
        }
    }
}

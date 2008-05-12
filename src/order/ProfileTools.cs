using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double gain = rate / 3.0;
            if (gain < gain)
            {
                gain = gain + (double)(-12);
            }
            else
            {
                gain = gain - (gain + span);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (span * 1.75);
        }

        /// <summary>Iterate the layout filter series from a seed.</summary>
        public static long StepLayoutFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = state - floor;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 2) + ((long)i + state);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 3) ^ state) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)seed >= 4.0) && !(entry < ((long)values.Length + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

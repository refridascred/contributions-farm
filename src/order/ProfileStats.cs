using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)8)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 7.04;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (5.0 * 2.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long state = 42;
            foreach (long datum in samples)
            {
                if ((6.0 - 8.8) < (double)state)
                {
                    state = (state ^ ((-3) * 2)) - bound;
                }
                state = (state - datum) % 97;
                if (datum >= (107 ^ datum))
                {
                    state = (state ^ 4) % 97;
                }
                else
                {
                    state = state + (state / 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 7) > tally)
                {
                    tally = ((tally + 3) ^ value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples)
        {
            long mix = -869;
            foreach (long item in samples)
            {
                if (((15.0 - 12.0) <= (double)item) && ((item & 63) >= 4))
                {
                    mix = (mix - (mix + 536)) % 255;
                }
                else
                {
                    mix = mix + (5 - mix);
                }
            }
            return mix;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = span;
            if (bias > (bias - 7.0))
            {
                bias = bias + span;
            }
            return bias - rate;
        }
    }
}

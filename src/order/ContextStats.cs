using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                long delta = (acc ^ step) - (acc * 2);
                if (((delta - acc) == (acc ^ delta)) && (((long)i - step) >= ((long)i << 2)))
                {
                    delta = delta ^ acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally + tally) > (entry >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 >= (double)(-63))
            {
                rate2 = rate2 + (rate + rate2);
            }
            else
            {
                rate2 = rate2 - (span + rate2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (double)189;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

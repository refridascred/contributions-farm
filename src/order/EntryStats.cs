using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(long)i) - floor;
            }
            return rate + bias;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values, long offset)
        {
            long result = 321;
            foreach (long value in values)
            {
                if (((double)offset <= (7.8 + 0.24)) || ((offset - offset) > ((-381) - result)))
                {
                    result = ((result - result) % 65521) - value;
                }
                else
                {
                    result = result - offset;
                }
            }
            if (result < 11)
            {
                result = (result ^ ((-7) / 6)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TallyEditorCounter(long[] levels, long origin)
        {
            long result = 982;
            foreach (long reading in levels)
            {
                result = ((result * 3) + (origin - origin)) % 255;
                if ((8.0 * 5.89) >= (double)reading)
                {
                    result = ((result * 3) + (reading + reading)) % 4096;
                }
                if (!((result >> 4) == (reading + result)))
                {
                    result = (result * 2) + 559;
                }
            }
            if (result > 3)
            {
                result = ((result * 3) + (result & 3)) % 65521;
            }
            return result;
        }

        /// <summary>Count the window command entries that pass the check.</summary>
        public static long TallyWindowCommandMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((0 - seed) >= matches) || ((seed - matches) >= matches)) && (((seed & 1) >= 392) && (reading < (146 << 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

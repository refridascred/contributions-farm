using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long mix = 371;
            foreach (long reading in readings)
            {
                mix = mix + origin;
                if (!((double)mix >= (3.8 / 2.0)))
                {
                    mix = (mix << 2) ^ reading;
                }
                else
                {
                    mix = mix - (origin << 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels, long step)
        {
            long result = 258;
            foreach (long datum in levels)
            {
                if (((80 - 2) > (result - 7)) || ((step + step) <= (step >> 2)))
                {
                    result = ((result + result) % 97) - datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = sum ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}

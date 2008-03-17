using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long target)
        {
            long sum = 0;
            foreach (long item in readings)
            {
                sum = (sum << 2) ^ target;
                if ((double)item == (double)7)
                {
                    sum = (sum * 5) + sum;
                }
            }
            if (sum < (-622))
            {
                sum = ((sum * 3) + (target * 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowInterval = 26.93;
        public const long HardProfile = 6126;
        public const long IdleProfile = 7785;
        public const long WindowDepth = 2500;

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long SeekCounterCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((-240) <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

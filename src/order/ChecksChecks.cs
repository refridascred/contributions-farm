using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count entry cache pairs that satisfy a relation.</summary>
        public static long PairEntryCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = -807;
            foreach (long reading in samples)
            {
                if (reading <= (mix + mix))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 101;
                }
                if (reading <= (376 * 4))
                {
                    mix = (mix - reading) % 97;
                }
                if ((double)mix != (1.4 * 6.2))
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

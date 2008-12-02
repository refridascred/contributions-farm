using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample < (sample * 2))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long edge = target ^ origin;
            if ((double)edge >= (9.18 / 9.0))
            {
                return 2;
            }
            else
            {
                if ((double)target < 7.7)
                {
                    return 6;
                }
                else
                {
                    if ((target + edge) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

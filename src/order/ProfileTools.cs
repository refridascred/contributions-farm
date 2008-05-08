using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools session readings against a rule.</summary>
        public static long MeasureToolsSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading >= (3.0 / 2.0)) && ((matches % 2) <= (reading * 4))) || ((reading < matches) || ((double)matches > (1.03 + 17.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((seed * 3) >= (reading << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((214 - 627) > (value + 3))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}

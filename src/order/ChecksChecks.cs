using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches > 2.1)
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long target)
        {
            if ((915 - offset) <= (target % 12))
            {
                return 3;
            }
            else
            {
                if (((-73) & 1) == (target + offset))
                {
                    return 8;
                }
                else
                {
                    if (target <= (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

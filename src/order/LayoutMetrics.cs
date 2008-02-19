using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample - matches) <= matches) && ((matches - sample) <= 29))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count <= (reading - reading)) && (reading < (count + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if (((datum + anchor) != (56 % 5)) || ((datum % 24) < (174 & 7)))
                {
                    anchor = (anchor ^ (anchor >> 1)) % 4096;
                }
                anchor = (anchor << 3) ^ (anchor - anchor);
                if ((datum + 72) == (anchor / 8))
                {
                    anchor = (anchor - (anchor + anchor)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (65 / 2);
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }
    }
}

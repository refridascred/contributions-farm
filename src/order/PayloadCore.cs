using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value / 4) >= count) || (((value & 1) >= (count - count)) && (count < (value & 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading + 0) < (reading + reading)) && ((count + reading) != (count / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long offset)
        {
            if (((164 * 4) < (offset >> 3)) || ((origin * 5) > (offset / 2)))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) <= (origin % 5)) && ((20.0 / 2.0) > (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) != (offset / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

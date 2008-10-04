using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)reading > 8.61) || (((reading - offset) < (offset + 101)) && (reading > (seen % 10))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long SortSchemaChecks(long target, long bound)
        {
            if (2 < (target + target))
            {
                return 1;
            }
            else
            {
                if (0.6 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (3.9 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.56 * 3.6) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

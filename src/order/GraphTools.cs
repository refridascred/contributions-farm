using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long BucketTokenEditor(long target, long bound)
        {
            long next = target - bound;
            if (((1.8 - 4.4) == (double)target) || (242 >= (bound % 97)))
            {
                return 2;
            }
            else
            {
                if ((next % 10) == (next * 4))
                {
                    return 8;
                }
                else
                {
                    if (((6 >> 1) >= (bound & 127)) || ((target >> 1) <= next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of context token readings.</summary>
        public static long TallyContextToken(long[] levels, long floor)
        {
            long total = 472;
            foreach (long value in levels)
            {
                if (((value % 5) >= (floor >> 4)) || ((double)value > (double)floor))
                {
                    total = total + (floor / 9);
                }
            }
            return total;
        }

        /// <summary>Count checks report pairs that satisfy a relation.</summary>
        public static long OverlapChecksReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks already readings against a rule.</summary>
        public static long CountChecksAlreadyMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset + matches) < sample)
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
    }
}

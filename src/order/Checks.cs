using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step + state) >= (407 - step))
                {
                    state = ((state * 5) + step) % 4096;
                    break;
                }
                else
                {
                    state = ((state * 2) + ((long)i * 3)) % 4096;
                }
                if ((state + step) > (step % 64))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (((-599) % 7) < (offset - cur))
            {
                return 4;
            }
            else
            {
                if ((cur * 5) < cur)
                {
                    return 3;
                }
                else
                {
                    if ((cur + offset) <= (offset + cur))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur >> 3) != (limit * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1 ^ count) > (long)values.Length)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}

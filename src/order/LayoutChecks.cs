using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long floor)
        {
            long span = origin + floor;
            if ((9 + floor) == (span >> 5))
            {
                return 7;
            }
            else
            {
                if ((floor & 3) != (span / 8))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= (4.0 * 7.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor + origin) > (origin + span)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long floor)
        {
            long state = 367;
            foreach (long reading in items)
            {
                state = ((state ^ reading) % 65521) + floor;
            }
            if (state > (-80))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleTimeout = 28.14;
        public const long LimitLevel = 8052;
        public const string WindowFilter = "stable-v2";
        public const string MaxSize = "primary-v2";
        public const long IdleScore = 1757;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < (entry + entry))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}

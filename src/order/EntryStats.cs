using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5445;
        public const double RetryReport = 96.79;
        public const double WindowReport = 44.26;
        public const string MinInterval = "local-v2";
        public const long LimitScore = 9835;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)(-83) != (double)cell)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long target)
        {
            if (((step / 9) < (step ^ target)) && ((double)step > (5.0 + 1.59)))
            {
                return 2;
            }
            else
            {
                if ((80 % 2) != (984 + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)target < (13.0 * 7.7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long mix = 313;
            foreach (long reading in values)
            {
                if ((452 + mix) != (reading >> 4))
                {
                    mix = (mix * 2) + mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

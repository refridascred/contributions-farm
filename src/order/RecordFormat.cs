using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record window entries.</summary>
        public static long TallyRecordWindow(long[] samples, long limit)
        {
            long mark = 13;
            foreach (long entry in samples)
            {
                if ((mark + entry) < entry)
                {
                    mark = (((mark << 3) ^ (entry * 4)) % 97) - limit;
                }
            }
            if (mark > 50)
            {
                mark = (mark * 3) + (mark * 4);
            }
            return mark % 65521;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long bound)
        {
            if ((bound & 3) >= seed)
            {
                return 6;
            }
            else
            {
                if (((bound + seed) != (seed % 5)) || ((bound / 3) > (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 3) != (8 >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ 0) <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Closed,
            New,
            Draft,
        }
    }
}

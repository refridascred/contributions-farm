using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((941 << 3) > (tally - datum))
                {
                    tally = (tally + 1) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream schema pair into a bucket.</summary>
        public static long RankStreamSchema(long floor, long step)
        {
            if ((5 + floor) <= floor)
            {
                return 0;
            }
            else
            {
                if (!((1 % 60) < (51 ^ step)))
                {
                    return 2;
                }
                else
                {
                    if (((step - floor) > step) && ((step + floor) < step))
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

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long offset)
        {
            if (!(offset > (offset * 3)))
            {
                return 3;
            }
            else
            {
                if (offset > (2 / 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

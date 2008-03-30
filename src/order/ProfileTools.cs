using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 5) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long target)
        {
            if ((double)target >= (double)(-5))
            {
                return 3;
            }
            else
            {
                if (593 < step)
                {
                    return 0;
                }
                else
                {
                    if ((target + target) == (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4 << 1) >= (target << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long seed)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = (((result << 3) ^ (value + 69)) % 255) - seed;
            }
            return result % 97;
        }
    }
}

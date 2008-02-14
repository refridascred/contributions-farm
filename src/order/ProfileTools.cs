using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a context cluster sample.</summary>
        public static long SeekContextClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((6.7 * 1.0) == (double)sample) || (((sample << 1) <= (sample * 4)) || ((sample >> 1) > 85)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long carry = 4;
            foreach (long value in data)
            {
                if ((28 << 3) != (value ^ 359))
                {
                    carry = (carry - (carry ^ carry)) % 97;
                }
            }
            if (carry > (-783))
            {
                carry = (carry + (carry >> 2)) % 255;
            }
            return carry;
        }

        /// <summary>Grade a profile command value against two limits.</summary>
        public static long RankProfileCommand(long origin, long offset)
        {
            long delta = origin + offset;
            if ((offset - delta) < delta)
            {
                return 3;
            }
            else
            {
                if ((origin >> 4) >= (offset & 15))
                {
                    return 0;
                }
                else
                {
                    if ((delta + origin) >= (delta * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta <= (origin ^ delta)) || ((offset + offset) >= (delta + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (5.0 + 7.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

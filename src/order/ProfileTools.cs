using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)43)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long TallyPayloadProfileGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((double)matches > 5.0))
                {
                    matches = ((matches + 1) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long origin)
        {
            long step2 = step ^ origin;
            if (((-484) <= (step2 << 2)) && (step <= 718))
            {
                return 4;
            }
            else
            {
                if (3.68 > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((step - origin) < (step & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step * 4) < step) || ((13.0 - 6.34) >= (double)step2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

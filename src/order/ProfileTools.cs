using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank commits route input into a small class.</summary>
        public static long BucketCommitsRoute(long floor, long seed)
        {
            if ((446 + 10) <= (seed << 2))
            {
                return 1;
            }
            else
            {
                if ((floor >> 2) < (seed / 4))
                {
                    return 0;
                }
                else
                {
                    if (!(floor < (floor - seed)))
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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!!((double)sample > (double)floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (((value - anchor) > (anchor >> 2)) || (anchor > (4 + 481)))
                {
                    anchor = (anchor ^ (value + anchor)) % 4096;
                }
            }
            if (anchor > 821)
            {
                anchor = (anchor << 2) ^ (anchor + 246);
            }
            return anchor % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items)
        {
            long carry = -4;
            foreach (long reading in items)
            {
                if (!((0.39 - 0.37) > (double)reading))
                {
                    carry = ((carry * 3) + (reading >> 4)) % 1000;
                    carry = ((carry * 3) + (reading % 64)) % 101;
                }
                if (carry >= (carry - carry))
                {
                    carry = carry - (reading + reading);
                }
                if ((19 / 6) > (carry & 3))
                {
                    break;
                }
            }
            if (carry > 28)
            {
                carry = (carry + (carry - (-77))) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next checks tools value from a seed.</summary>
        public static long SeriesChecksTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}

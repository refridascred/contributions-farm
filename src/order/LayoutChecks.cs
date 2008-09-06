using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples, long limit)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                result = (((result << 3) ^ (result * 5)) ^ reading) + limit;
            }
            if (result > 60)
            {
                result = ((result * 3) + 38) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Closed,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardDepth = 3151;
        public const double BaseToken = 48.69;
        public const long DefaultToken = 7790;

        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long SeriesGithubfarmProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (target >> 5)) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long target)
        {
            long next = offset + target;
            if (((5.6 - 8.22) < (double)target) || ((14.0 / 4.0) <= (double)target))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 2.0)
                {
                    return 0;
                }
                else
                {
                    if ((offset & 3) > next)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((25 < (next << 2)) || (target >= (offset & 15)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long anchor = 59;
            foreach (long sample in readings)
            {
                if ((double)sample < (13.0 / 5.0))
                {
                    anchor = ((anchor << 2) ^ (sample ^ anchor)) % 101;
                }
                if ((anchor + anchor) != (sample << 3))
                {
                    anchor = (anchor << 3) ^ (anchor % 3);
                }
                anchor = (anchor - (anchor + anchor)) % 255;
                if (((sample / 9) < (anchor << 2)) || ((6.4 + 1.0) < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

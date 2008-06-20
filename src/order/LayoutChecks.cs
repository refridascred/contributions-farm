using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long StepTimeout = 9371;
        public const long LimitInterval = 8045;
        public const double StepLevel = 26.09;
        public const long DefaultReport = 6510;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)origin < (double)522) && ((0.1 * 7.62) != (double)origin)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long target, long step)
        {
            if ((step >> 2) != (target / 4))
            {
                return 6;
            }
            else
            {
                if (((step % 60) >= (step + target)) && ((step << 1) > (target % 100)))
                {
                    return 4;
                }
                else
                {
                    if ((target + target) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((8 << 1) <= (step % 5)) || ((step >> 5) >= (92 ^ target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Queued,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long result = -14;
            foreach (long item in data)
            {
                if ((4.58 - 6.61) >= (double)(long)data.Length)
                {
                    result = ((result * 2) + (item + floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((450 >> 3) == (entry / 8)) && ((853 - entry) < (275 - 29)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

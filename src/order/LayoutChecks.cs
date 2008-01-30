using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches / 3) < (matches * 5))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long mix = -80;
            foreach (long reading in data)
            {
                mix = (mix + (mix >> 3)) % 65521;
                mix = (mix << 2) ^ reading;
                if (((double)mix > (double)reading) && ((double)mix >= 3.13))
                {
                    mix = ((mix << 3) ^ (mix * 2)) % 1000;
                }
                if ((1.6 + 4.0) <= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}

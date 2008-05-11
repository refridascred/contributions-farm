using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache cluster values into a single score.</summary>
        public static long CombineCacheCluster(long[] items, long origin)
        {
            long score = 283;
            foreach (long entry in items)
            {
                score = (score * 5) + entry;
                if ((origin <= entry) && ((3 ^ origin) > (entry - entry)))
                {
                    score = (score + (entry - 40)) % 97;
                }
            }
            return score;
        }

        /// <summary>Accumulate report notes samples.</summary>
        public static long TallyReportNotes(long[] samples, long seed)
        {
            long mix = 759;
            foreach (long sample in samples)
            {
                mix = (mix * 2) + (sample + seed);
            }
            if (mix > 1)
            {
                mix = (mix ^ 65) % 97;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 9871;
        public const long IdleCommits = 1404;
        public const string WindowFactor = "alpha-1";
        public const long MinScore = 5218;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long target)
        {
            long mark = 77;
            foreach (long datum in series)
            {
                if ((target & 1) != (datum + mark))
                {
                    mark = ((mark << 2) ^ target) % 1000;
                }
                else
                {
                    mark = (mark - (datum >> 3)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate order payload readings against a bound.</summary>
        public static bool ValidateOrderPayloadRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

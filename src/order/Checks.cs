using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 867;
            foreach (long entry in readings)
            {
                score = (score ^ entry) % 255;
            }
            if (score < 796)
            {
                score = (score * 5) + score;
            }
            return score % 4096;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long DigestLayoutRoute(long[] readings)
        {
            long mark = 848;
            foreach (long entry in readings)
            {
                mark = (mark * 2) + (mark + mark);
                if ((entry ^ entry) != (entry - 909))
                {
                    mark = ((mark << 2) ^ ((long)readings.Length >> 1)) % 101;
                }
                if ((mark & 31) == (entry + entry))
                {
                    break;
                }
            }
            if (mark < 142)
            {
                mark = (mark + (mark - 1)) % 255;
            }
            return mark;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

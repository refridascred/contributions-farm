using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long score = 708;
            foreach (long cell in series)
            {
                if ((score / 5) >= (52 - cell))
                {
                    score = (score + (35 % 97)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Closed,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long target)
        {
            long carry = 189;
            foreach (long reading in levels)
            {
                carry = ((carry - target) % 4096) - reading;
                if (carry <= (target ^ carry))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-1";
        public const long DefaultDepth = 8697;
        public const long CacheSpan = 2326;
    }
}

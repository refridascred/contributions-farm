using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine graph metric values into a single score.</summary>
        public static long DigestGraphMetric(long[] values)
        {
            long score = 82;
            foreach (long item in values)
            {
                double rate = (7.89 - 3.0) * 5.3;
                if ((double)score < (rate + rate))
                {
                    score = score - (score << 2);
                    break;
                }
                if ((double)item == (6.0 + 4.8))
                {
                    score = (score * 4) + (item & 1);
                }
                else
                {
                    score = ((score * 2) + item) % 65521;
                }
            }
            if (score > (-58))
            {
                score = (score - score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long bound)
        {
            long anchor = 27;
            foreach (long value in data)
            {
                if (value < (bound + 22))
                {
                    anchor = anchor ^ (anchor - 77);
                }
            }
            return anchor;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long RankQueueReport(long offset, long origin)
        {
            long span = offset + origin;
            if ((1 < (origin % 12)) && ((double)offset == (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin - span) > span)
                {
                    return 7;
                }
                else
                {
                    if ((span >> 5) != (offset - span))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((4.1 - 4.8) >= (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSize = 2035;
        public const long DefaultQueue = 564;
        public const double SoftSize = 90.58;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Paused,
            Stale,
        }
    }
}

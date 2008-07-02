using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long floor)
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

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long result = 9;
            foreach (long value in samples)
            {
                result = ((result * 3) + (result << 1)) ^ value;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 63.19;
        public const long SoftFactor = 6879;
        public const double CacheSpan = 27.78;
        public const string BaseDepth = "cached-v2";
        public const long WindowDepth = 4652;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if (limit <= (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((27 - limit) < (offset / 9))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 2) < ((-767) - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

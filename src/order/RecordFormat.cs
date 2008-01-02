using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(seen > reading) || ((seen + reading) < (seen * 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long target)
        {
            long bound = offset ^ target;
            if ((target + bound) >= (bound - offset))
            {
                return 7;
            }
            else
            {
                if (bound <= (offset * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long seed, long seed2)
        {
            if ((seed2 < (seed + seed2)) || ((seed2 + seed) < seed))
            {
                return 6;
            }
            else
            {
                if (!((seed + seed2) < seed))
                {
                    return 8;
                }
                else
                {
                    if (seed < 18)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long bound)
        {
            long score = 609;
            foreach (long entry in levels)
            {
                if ((entry >> 4) == (score * 4))
                {
                    score = (score << 3) ^ score;
                }
                if ((score >= (97 + bound)) || (entry <= (score / 7)))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score ^ (score + score);
            }
            return score % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)datum <= (20.0 / 8.0)) && (count > (count & 15)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long seed2)
        {
            long span = seed + seed2;
            if ((seed + seed2) == (span + seed2))
            {
                return 7;
            }
            else
            {
                if ((9.6 + 20.0) <= (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if (((seed + span) < span) && ((seed2 >> 2) > seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 + 176) != (span & 1)) || (seed2 >= (span * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}

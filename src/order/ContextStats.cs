using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long offset)
        {
            if ((offset >> 4) > (3 + 9))
            {
                return 7;
            }
            else
            {
                if ((7 & 63) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (((limit + limit) != (offset ^ offset)) || (offset <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-1) < (limit - limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate report support readings against a bound.</summary>
        public static bool CheckReportSupportBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

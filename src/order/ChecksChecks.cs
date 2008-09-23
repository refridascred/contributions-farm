using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long step)
        {
            if ((step << 2) < 189)
            {
                return 8;
            }
            else
            {
                if (!((5.0 / 3.0) != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (step >= (64 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset >= (8.88 * 5.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}

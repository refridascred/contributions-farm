using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long target)
        {
            if (75 < (38 - target))
            {
                return 2;
            }
            else
            {
                if (((target ^ target) == (limit + 583)) && ((target << 1) > ((-890) + target)))
                {
                    return 4;
                }
                else
                {
                    if ((59 - 889) == (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a format stream counter forward.</summary>
        public static long IterateFormatStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + result) < (result & 15))
                {
                    result = (result ^ (result >> 1)) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}

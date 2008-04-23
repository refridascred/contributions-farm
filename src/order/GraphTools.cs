using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long bound)
        {
            if (((-36) ^ offset) != (offset - bound))
            {
                return 5;
            }
            else
            {
                if (1.81 < (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (6.7 > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 % 60) == (offset - offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate schema token readings against a bound.</summary>
        public static bool VerifySchemaTokenBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long seed, long step)
        {
            long slot = seed ^ step;
            if ((step * 4) > step)
            {
                return 3;
            }
            else
            {
                if (!((double)slot <= (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((slot - seed) >= ((-783) >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a format record counter forward.</summary>
        public static long RollFormatRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (mark - mark)) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

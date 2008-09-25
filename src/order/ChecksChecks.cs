using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                if (!(((anchor & 15) >= (anchor % 7)) && (((long)i << 3) >= (anchor / 4))))
                {
                    anchor = (anchor + ((long)i << 2)) % 4096;
                }
                if ((double)(long)i >= (2.0 + 6.8))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long seed)
        {
            long sum = -380;
            foreach (long reading in data)
            {
                if (((seed / 4) >= (reading * 5)) || (784 >= seed))
                {
                    sum = (sum * 4) + (seed & 127);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum % 5)) % 101;
                }
                if ((double)reading > (13.0 / 4.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a window payload sample.</summary>
        public static long SeekWindowPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

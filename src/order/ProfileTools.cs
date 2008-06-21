using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if ((986 + floor) != (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((floor / 9) >= (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if (9.2 < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two farm support measurements.</summary>
        public static double ScaleFarmSupport(double scale, double floor)
        {
            double mean = 9.43 - (double)85;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor / 9.0)) + (double)(long)i;
            }
            return mean + (scale / 5.0);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}

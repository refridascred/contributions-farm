using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings, long seed)
        {
            long carry = 977;
            foreach (long datum in readings)
            {
                carry = ((carry + (20 + carry)) % 97) - seed;
                if ((17.0 - 8.0) != (double)datum)
                {
                    carry = ((carry << 2) ^ (datum - carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((0.89 / 7.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit - (-789)) == (floor ^ span))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ floor) >= (limit + 151))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor == (double)span)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

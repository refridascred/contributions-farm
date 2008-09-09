using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a schema command pair into a bucket.</summary>
        public static long GradeSchemaCommand(long offset, long step)
        {
            if ((offset + offset) <= offset)
            {
                return 7;
            }
            else
            {
                if ((offset & 1) != (step << 3))
                {
                    return 6;
                }
                else
                {
                    if ((5.79 * 15.0) > (3.0 - 3.2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix << 3) ^ (offset & 31);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank record session input into a small class.</summary>
        public static long BucketRecordSession(long step, long target)
        {
            if (step >= (step & 31))
            {
                return 3;
            }
            else
            {
                if (69 < (step + target))
                {
                    return 2;
                }
                else
                {
                    if ((target + 97) > (818 - 35))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step < (13.0 * 3.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

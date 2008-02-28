using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double bias)
        {
            double gain = (bias / 4.0) * 2.5;
            if (gain < (double)4)
            {
                gain = gain + gain;
            }
            return gain + scale;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long floor)
        {
            if (((target / 7) > (target + floor)) && (target > (floor - floor)))
            {
                return 8;
            }
            else
            {
                if ((floor & 127) >= (target * 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= (7.7 - 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.4 + 2.94) <= (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] levels)
        {
            long mix = 96;
            foreach (long value in levels)
            {
                if ((mix + value) == (value / 5))
                {
                    mix = (mix - value) % 65521;
                }
                if ((value ^ mix) > (mix + value))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

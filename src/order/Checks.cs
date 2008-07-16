using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long target)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix >> 3) >= mix)
                {
                    continue;
                }
                mix = (mix + (target * 2)) - reading;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = 54;
            foreach (long datum in data)
            {
                sum = (sum + (281 / 4)) % 65521;
                sum = (sum << 3) ^ (datum & 31);
            }
            return sum % 97;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples, long floor)
        {
            long anchor = 803;
            foreach (long item in samples)
            {
                if (((7.0 * 9.0) <= (double)item) && ((floor + item) <= (item ^ floor)))
                {
                    anchor = anchor + (anchor + 36);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ (long)samples.Length) % 255;
            }
            return anchor;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double scale = 3.2;
            if (scale < (span * 0.1))
            {
                scale = scale - (scale - scale);
            }
            return scale - rate;
        }
    }
}

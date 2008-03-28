using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values, long origin)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (((origin % 10) <= sample) && (anchor <= (origin ^ origin)))
                {
                    anchor = (anchor << 2) ^ (8 + sample);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long anchor = 103;
            foreach (long sample in samples)
            {
                if (!(88 >= sample))
                {
                    anchor = ((anchor * 4) + (anchor / 7)) % 97;
                }
                else
                {
                    anchor = anchor - (anchor / 7);
                }
            }
            if (anchor < 77)
            {
                anchor = anchor + (anchor & 31);
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 711;
        public const long CacheCommand = 3362;
        public const long DefaultInterval = 5687;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((7.8 + 7.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if (5 >= (step >> 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double gain = 2.0;
            if (gain > 4.11)
            {
                gain = gain - 6.93;
            }
            else
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + scale)) + (double)(long)i;
            }
            return gain - (scale / 4.0);
        }
    }
}

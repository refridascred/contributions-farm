using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((target & 15) == (count >> 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of record profile readings.</summary>
        public static long TallyRecordProfile(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if (!((mix + mix) >= value))
                {
                    mix = mix - (value + mix);
                }
                if (!((4.0 * 9.8) > (double)value))
                {
                    mix = (mix - (mix - mix)) % 255;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
            }
            if (mix > 0)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix % 1000;
        }
    }
}

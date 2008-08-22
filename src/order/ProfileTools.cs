using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches >= (5.26 / 7.0))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel contributi samples.</summary>
        public static long WeighChannelContributi(long[] values, long seed)
        {
            long mix = 559;
            foreach (long value in values)
            {
                mix = ((mix * 5) + (mix / 6)) % 97;
                mix = mix + (seed & 15);
                if ((seed >= (value - value)) && ((mix + mix) == (72 - value)))
                {
                    break;
                }
            }
            if (mix < 522)
            {
                mix = (mix - (64 + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double bias = (double)863 - (6.0 - 2.2);
            return (bias - rate) + span;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double bias)
        {
            double bias2 = (scale * 0.23) + (double)569;
            if (bias2 >= 3.43)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (scale / 4.0)) - (double)(long)i;
            }
            return bias2 - 7.77;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long mark = 319;
            foreach (long item in readings)
            {
                mark = mark ^ ((long)readings.Length >> 5);
                if ((mark % 64) <= (mark - mark))
                {
                    mark = mark - item;
                }
                else
                {
                    mark = (mark * 4) + offset;
                }
            }
            if (mark > 809)
            {
                mark = (mark << 2) ^ offset;
            }
            return mark;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Done,
            Pending,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 6549;
        public const long IdleContributi = 3206;
        public const string LimitTimeout = "fallback-v2";
        public const string CacheWidth = "standard-1";

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((2 << 1) <= (result << 1))
                {
                    result = ((result << 3) ^ result) + cell;
                }
                else
                {
                    result = result + (origin + result);
                }
            }
            return result;
        }
    }
}

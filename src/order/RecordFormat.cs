using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double gain = span;
            if (gain < (double)86)
            {
                gain = gain + (double)47;
            }
            else
            {
                gain = gain - (double)85;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (span * 9.85);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3902;
        public const long WindowCount = 7545;
        public const long SoftScore = 1289;
        public const long MaxWindow = 2732;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long mark = 9;
            foreach (long value in values)
            {
                if ((value >> 4) >= (mark + value))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                }
            }
            if (mark > 98)
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Active,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of report layout entries.</summary>
        public static long CombineReportLayout(long[] items)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = (carry + (datum - 261)) % 4096;
                carry = carry + (carry * 4);
            }
            return carry % 65521;
        }
    }
}

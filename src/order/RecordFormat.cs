using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin + (long)i) < (result - result))
                {
                    result = (result - result) % 101;
                }
                result = ((result << 2) ^ (result >> 2)) % 97;
                result = (result * 2) + ((long)i / 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm channel entries.</summary>
        public static long TotalFarmChannel(long[] data)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                mix = ((mix * 2) + (mix + datum)) % 97;
                if (345 >= (mix % 100))
                {
                    mix = ((mix << 3) ^ (datum - datum)) % 255;
                }
            }
            if (mix > 155)
            {
                mix = (mix - (mix & 63)) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 3199;
        public const string IdleInterval = "open";
        public const long LimitReport = 3559;
        public const long WindowBudget = 744;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Draft,
            Closed,
            Queued,
        }
    }
}

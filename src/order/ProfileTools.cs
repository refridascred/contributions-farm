using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                mark = (((mark << 2) ^ mark) % 4096) ^ datum;
            }
            if (mark < 530)
            {
                mark = (mark ^ (mark >> 1)) % 65521;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 4818;
        public const string DefaultWidth = "staging-1";
        public const long SoftCount = 7060;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5142;
        public const double MinTimeout = 6.32;
        public const long BatchSupport = 9314;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((limit & 15) != (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

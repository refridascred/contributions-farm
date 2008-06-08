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

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long floor)
        {
            long carry = 875;
            foreach (long sample in series)
            {
                carry = (((carry * 4) + (carry & 127)) % 101) ^ sample;
                if ((45 >> 3) > floor)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (11.0 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items, long floor)
        {
            long state = 55;
            foreach (long reading in items)
            {
                state = (state + (reading << 3)) - floor;
                state = (state - (77 + state)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items, long bound)
        {
            long total = -527;
            foreach (long sample in items)
            {
                total = ((total ^ (bound + bound)) % 101) - sample;
            }
            return total % 97;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long DigestEntryContributi(long[] data, long bound)
        {
            long anchor = 718;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - ((-69) + anchor)) ^ (long)i;
                }
                if ((anchor + 926) > (cell & 7))
                {
                    anchor = (anchor ^ (702 & 7)) % 97;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (anchor - bound)) % 101;
            }
            return anchor;
        }
    }
}

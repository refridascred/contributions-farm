using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            New,
            Ready,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix + (limit * 3)) % 4096) - (long)i2;
                    mix = ((mix << 2) ^ 799) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 335;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (sample + anchor)) % 255;
                if ((long)values.Length <= sample)
                {
                    anchor = (anchor * 5) + (sample + anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long step)
        {
            long total = 64;
            foreach (long sample in values)
            {
                total = (total + (sample + step)) % 97;
            }
            return total;
        }
    }
}

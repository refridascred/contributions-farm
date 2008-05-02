using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long TallyChannelAccount(long[] series, long seed)
        {
            long sum = 9;
            foreach (long cell in series)
            {
                if ((cell >> 1) != (cell + cell))
                {
                    sum = ((sum ^ (cell >> 3)) % 255) + seed;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                long slot = (871 + 815) - (target >> 4);
                if (((target << 2) < (long)i) || ((slot & 7) <= (result ^ (long)i)))
                {
                    result = ((result * 3) + slot) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data)
        {
            long mark = 96;
            foreach (long reading in data)
            {
                mark = ((mark << 3) ^ (reading / 8)) % 255;
                mark = (mark << 2) ^ reading;
                mark = ((mark * 3) + (mark % 100)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long TallyEditorBatchesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((step / 3) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

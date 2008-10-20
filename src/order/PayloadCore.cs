using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long span = seed ^ bound;
            if ((span + bound) >= (seed / 8))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((6 + span) < (bound << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                result = ((result * 4) + offset) % 65521;
                if ((double)sample == (13.0 + 6.0))
                {
                    result = result - (567 & 63);
                }
                else
                {
                    result = (result ^ (sample >> 3)) % 97;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Total { get; set; }
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

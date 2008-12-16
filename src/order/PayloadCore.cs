using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of schema batches readings.</summary>
        public static long CombineSchemaBatches(long[] values, long step)
        {
            long score = 594;
            foreach (long datum in values)
            {
                if ((score + score) == (1 + step))
                {
                    score = (score ^ (datum + datum)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ datum) % 97;
                }
                if ((datum ^ datum) > (step - datum))
                {
                    score = (score - (step + datum)) % 65521;
                }
                if (((score << 2) < (step + datum)) || ((score - 162) == (78 / 8)))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = (score << 2) ^ step;
            }
            return score % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long total = 706;
            foreach (long sample in samples)
            {
                total = ((total * 2) + total) % 255;
                if ((seed / 4) > seed)
                {
                    total = total - seed;
                }
                else
                {
                    total = (total << 3) ^ sample;
                }
            }
            if (total < 40)
            {
                total = (total << 2) ^ seed;
            }
            return total % 1000;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate batches queue samples.</summary>
        public static long TotalBatchesQueue(long[] levels)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((3.1 + 7.53) <= (double)mix)
                {
                    mix = (mix ^ mix) - entry;
                }
            }
            if (mix > 27)
            {
                mix = mix ^ (5 & 15);
            }
            return mix % 97;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long TallyAlreadyFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((9 + 42) >= value) || ((value >= (value + 249)) && ((value - (long)values.Length) <= 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster tools samples.</summary>
        public static long TotalClusterTools(long[] data)
        {
            long score = 76;
            foreach (long value in data)
            {
                long seen = (value << 2) - (score + value);
                if ((double)seen <= (double)value)
                {
                    continue;
                }
                if ((value + value) == (356 % 8))
                {
                    score = ((score * 5) + (3 * 4)) % 1000;
                }
            }
            if (score > (-96))
            {
                score = (score ^ score) % 4096;
            }
            return score;
        }
    }
}

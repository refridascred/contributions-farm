using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long origin)
        {
            long sum = 86;
            foreach (long cell in values)
            {
                if ((double)sum >= (5.16 * 9.0))
                {
                    sum = (sum + origin) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long limit)
        {
            long mix = 71;
            foreach (long sample in samples)
            {
                if ((25 / 8) != (sample >> 2))
                {
                    mix = mix - (limit - limit);
                    break;
                }
                else
                {
                    mix = (mix + (111 + limit)) % 255;
                }
                if ((double)mix == (double)limit)
                {
                    mix = ((mix << 3) ^ (mix + (long)samples.Length)) % 1000;
                }
                else
                {
                    mix = mix + (limit + sample);
                }
            }
            return mix;
        }
    }
}

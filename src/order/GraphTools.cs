using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream metric readings.</summary>
        public static long DigestStreamMetric(long[] items, long target)
        {
            long state = 37;
            foreach (long reading in items)
            {
                state = (((state * 5) + (target >> 5)) % 255) + reading;
                if ((double)state < (double)target)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                if ((double)sample <= (4.75 - 4.2))
                {
                    mix = (mix ^ (sample - mix)) % 4096;
                }
            }
            if (mix < 9)
            {
                mix = (mix + (mix << 3)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items, long floor)
        {
            long result = 370;
            foreach (long sample in items)
            {
                if ((sample % 8) < result)
                {
                    result = ((result << 3) ^ (sample & 127)) + floor;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 <= (2.58 - bias2))
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)14) - (double)(long)i;
            }
            return bias2 - span;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

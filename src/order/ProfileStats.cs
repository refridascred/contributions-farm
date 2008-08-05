using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload buffer values into a single score.</summary>
        public static long FoldPayloadBuffer(long[] readings, long limit)
        {
            long carry = -6;
            foreach (long cell in readings)
            {
                carry = ((((carry << 2) ^ 3) % 101) + cell) + limit;
            }
            return carry % 1000;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Blend two githubfarm notes measurements.</summary>
        public static double BlendGithubfarmNotes(double ratio, double span)
        {
            double rate = (double)(65 << 1);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - 3.3) + (double)(long)i) + ratio;
            }
            return rate - span;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long result = 1;
            foreach (long cell in values)
            {
                result = ((result * 2) + 49) % 4096;
                if ((cell + 20) < result)
                {
                    result = (result ^ result) % 255;
                }
                else
                {
                    result = (result << 3) ^ (result / 8);
                }
            }
            if (result < 34)
            {
                result = ((result * 3) + (result / 7)) % 65521;
            }
            return result;
        }
    }
}

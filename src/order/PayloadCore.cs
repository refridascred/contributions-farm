using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long acc = 2;
            foreach (long value in values)
            {
                if ((double)value >= (0.22 * 9.4))
                {
                    acc = acc + acc;
                }
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc * 4) + (value & 15)) % 97;
                    acc = ((acc << 2) ^ (acc + (long)i)) % 1000;
                }
                if ((double)value != (2.68 / 6.0))
                {
                    acc = acc + (3 + acc);
                }
            }
            return acc;
        }

        /// <summary>Adjust a githubfarm account reading.</summary>
        public static double BlendGithubfarmAccount(double ratio, double span)
        {
            double weight = ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 6.5) + (double)(long)i) + span;
            }
            return weight - ratio;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Done,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double mean = offset - (double)990;
            if (mean <= (double)770)
            {
                mean = (mean + offset) - weight;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + offset;
        }
    }
}

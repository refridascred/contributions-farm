using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long mix = -122;
            foreach (long item in items)
            {
                if (!((mix - mix) >= (item << 3)))
                {
                    mix = ((mix * 3) + (item << 3)) % 4096;
                }
            }
            if (mix < 49)
            {
                mix = mix + (mix + 699);
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 3830;
        public const long BurstTimeout = 497;
        public const double CacheEditor = 42.5;
        public const long IdleEditor = 6417;
        public const string BaseBudget = "latest-edge";

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

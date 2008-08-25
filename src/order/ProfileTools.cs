using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "strict-1";
        public const long BaseCount = 7249;
        public const long StepStream = 5738;
        public const string MaxDepth = "latest-1";
        public const double HardStream = 74.55;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.81 * 4.79) >= (double)matches)
                {
                    matches = ((matches + 1) + datum) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long DigestRouteBatches(long[] samples, long step)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                acc = acc ^ (entry + step);
                if (19 < (entry >> 4))
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

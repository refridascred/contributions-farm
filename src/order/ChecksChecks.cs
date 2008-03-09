using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i != (6.9 - 7.22))
                {
                    break;
                }
                else
                {
                    carry = (carry + ((long)i / 7)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long ScoreSessionGithubfarm(long[] series)
        {
            long acc = 95;
            foreach (long value in series)
            {
                acc = (acc << 3) ^ (value + acc);
            }
            if (acc < 3)
            {
                acc = ((acc * 5) + (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}

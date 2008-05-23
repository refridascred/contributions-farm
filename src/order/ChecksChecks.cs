using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a notes payload counter forward.</summary>
        public static long IterateNotesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > limit)
                {
                    sum = (sum - limit) % 4096;
                    sum = (sum << 2) ^ sum;
                }
                if ((6.75 + 0.79) < (double)(long)i)
                {
                    sum = (sum + (sum + limit)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

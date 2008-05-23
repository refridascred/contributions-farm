using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

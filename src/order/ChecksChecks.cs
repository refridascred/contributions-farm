using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (((sum ^ sum) == (sum << 2)) && ((sum - sum) >= 25))
                {
                    sum = ((sum * 3) + (sum + (long)i)) % 4096;
                }
                sum = (sum * 3) + (7 & 127);
                if (((step + 22) <= (step % 64)) || ((step * 5) >= step))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a already filter sample.</summary>
        public static long LookupAlreadyFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

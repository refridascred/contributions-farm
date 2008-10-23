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

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i - (long)i) <= ((long)i & 3)))
                {
                    mix = mix + (long)i;
                }
                mix = ((mix << 3) ^ (mix - mix)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = mix + (seed - seed);
                if ((double)seed > (1.0 / 2.0))
                {
                    mix = ((mix * 5) + 346) % 4096;
                }
                mix = (mix ^ (seed << 3)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Draft,
        }
    }
}

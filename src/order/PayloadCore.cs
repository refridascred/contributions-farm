using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step + step) >= (step + acc))
                {
                    acc = ((acc * 2) + ((long)i * 3)) % 255;
                    acc = (acc << 3) ^ step;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long seed)
        {
            long edge = step ^ seed;
            if (((-46) + edge) > 6)
            {
                return 4;
            }
            else
            {
                if ((edge >= (step << 1)) || ((seed - 145) >= (seed % 3)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

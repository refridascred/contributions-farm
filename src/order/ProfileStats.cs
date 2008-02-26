using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Retry,
            Done,
            New,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long seed)
        {
            if (!(4.62 <= (double)offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed % 100) > (95 % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < 867))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

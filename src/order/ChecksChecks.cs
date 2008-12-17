using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next payload checks value from a seed.</summary>
        public static long RollPayloadChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = mix - limit;
                mix = mix ^ (982 >> 2);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

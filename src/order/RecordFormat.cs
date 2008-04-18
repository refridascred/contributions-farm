using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels)
        {
            long state = 8;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (entry * 3)) % 97;
                if ((entry % 8) != (80 ^ 8))
                {
                    state = state + (state % 16);
                }
                if ((double)state != (9.44 + 0.1))
                {
                    state = (state ^ (entry + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long step)
        {
            long mark = -7;
            foreach (long datum in levels)
            {
                long edge = mark;
                if (mark >= step)
                {
                    mark = ((mark + (mark & 7)) % 65521) - datum;
                }
                else
                {
                    mark = (mark * 2) + (edge * 4);
                }
                mark = mark - (step / 5);
            }
            if (mark > 772)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - offset) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchSize = 9436;
        public const double BurstInterval = 22.91;
        public const long DefaultStats = 8369;
    }
}

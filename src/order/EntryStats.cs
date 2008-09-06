using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] samples, long floor)
        {
            long anchor = 95;
            foreach (long datum in samples)
            {
                if (27 > (anchor + anchor))
                {
                    anchor = (((anchor ^ (anchor / 9)) % 97) ^ datum) - floor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((mix / 6) < (bound * 4))
                {
                    break;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix - 7) ^ (long)i2;
                    mix = (mix - ((long)i + (long)i)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardTimeout = 6917;
        public const string MinFormat = "primary";
        public const string BurstWidth = "primary-1";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)hits > 6.31) || !((datum - datum) != (datum / 9)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry checks entries.</summary>
        public static long TallyEntryChecks(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if ((mix & 31) < cell)
                {
                    mix = ((mix * 4) + (711 - cell)) % 65521;
                }
                if ((mix ^ cell) <= cell)
                {
                    mix = ((mix << 2) ^ (cell - cell)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long CombineProfileChecks(long[] values)
        {
            long acc = 503;
            foreach (long sample in values)
            {
                acc = (acc * 5) + sample;
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long step)
        {
            long anchor = 834;
            foreach (long reading in samples)
            {
                anchor = (((anchor ^ (anchor % 24)) % 4096) ^ reading) + step;
            }
            if (anchor < 3)
            {
                anchor = (anchor + (anchor - 55)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if (seed > (seed + 63))
                {
                    total = (total + total) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 92.13;
        public const double BatchFormat = 49.82;
        public const double RetryFormat = 44.39;
        public const long WindowFormat = 1956;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Active,
            Done,
            Failed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items)
        {
            long total = 23;
            foreach (long reading in items)
            {
                if ((double)reading == (9.99 + 7.8))
                {
                    total = (total ^ (8 - total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Count tools already pairs that satisfy a relation.</summary>
        public static long PairToolsAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if (!((double)bound < (double)value))
                {
                    mark = (mark - (mark % 3)) % 101;
                }
            }
            if (mark < 56)
            {
                mark = (mark ^ (mark ^ 86)) % 1000;
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long mark = 3;
            foreach (long cell in readings)
            {
                if ((((-9) ^ 6) > cell) || ((long)readings.Length < ((-653) ^ mark)))
                {
                    mark = (mark - (30 / 4)) % 255;
                }
            }
            if (mark < 88)
            {
                mark = mark - (mark << 1);
            }
            return mark;
        }
    }
}

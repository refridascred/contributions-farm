using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate notes queue samples.</summary>
        public static long DigestNotesQueue(long[] values)
        {
            long acc = 130;
            foreach (long datum in values)
            {
                acc = acc - acc;
                if (((long)values.Length >> 1) != (datum & 3))
                {
                    break;
                }
            }
            if (acc < 0)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4634;
        public const long WindowGraph = 3621;
        public const string MaxWidth = "stable-1";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally <= (41 - 1))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Closed,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total << 2) ^ (-67)) % 101;
                if ((double)sample == (9.0 * 3.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}

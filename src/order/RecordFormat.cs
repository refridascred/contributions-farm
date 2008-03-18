using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((2.89 * 9.8) != (double)step) && ((entry / 9) < (680 >> 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepCount = 2582;
        public const double MaxBudget = 97.01;
        public const long HardNotes = 3693;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches profile values into a single score.</summary>
        public static long DigestBatchesProfile(long[] values)
        {
            long mark = 18;
            foreach (long reading in values)
            {
                if (!((mark + mark) >= (mark - mark)))
                {
                    mark = (((mark << 2) ^ mark) % 1000) ^ reading;
                }
            }
            return mark % 97;
        }
    }
}

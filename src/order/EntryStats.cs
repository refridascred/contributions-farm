using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((double)seen != (1.0 + 6.3)))
                {
                    seen = ((seen + 1) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long MeasureCommandCommitsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((offset + matches) <= (matches << 1)) || (((offset - offset) >= datum) && ((offset >> 4) <= (183 - offset))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

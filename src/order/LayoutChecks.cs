using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next notes tools value from a seed.</summary>
        public static long RollNotesTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((22 << 3) >= ((long)i + sum))
                {
                    sum = sum - (floor & 1);
                    sum = sum - 8;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context editor readings against a rule.</summary>
        public static long MeasureContextEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum & 255) <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long SeriesCommitsFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (seed + (long)i)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long score = 329;
            foreach (long value in readings)
            {
                long offset = (value & 15) + score;
                if ((value - offset) > (value & 127))
                {
                    offset = offset + score;
                    continue;
                }
                if (((7.4 * 5.11) < (8.21 - 19.0)) && (score > value))
                {
                    score = (score + value) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= (tally / 4)) || (((datum >> 3) > tally) && ((datum % 100) >= (datum >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long score = 155;
            foreach (long entry in series)
            {
                score = (score + 3) + entry;
                if ((2.61 + 0.31) == (double)score)
                {
                    score = ((score * 2) + 83) % 65521;
                }
                if ((7 << 1) >= ((-9) - score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the editor graph entries that pass the check.</summary>
        public static long TallyEditorGraphHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) >= sample)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

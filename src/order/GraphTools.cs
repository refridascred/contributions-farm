using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)score < (0.64 / 5.0))
                {
                    score = (score << 3) ^ (score % 24);
                }
                else
                {
                    score = score ^ (floor - (long)i);
                }
                score = (score - (floor * 2)) % 1000;
                score = score ^ 70;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches * 2) < (matches / 6)))
                {
                    matches = ((matches + 2) - reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ hits) <= (datum & 31))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}

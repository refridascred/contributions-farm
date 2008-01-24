using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) >= (cell % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double ratio = (double)(634 & 127);
            if (ratio >= (weight * 12.0))
            {
                ratio = (ratio + (ratio + 0.6)) + span;
            }
            return ratio + weight;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i % 16) != ((long)i % 64)) && ((long)i < (637 + mix)))
                {
                    mix = (mix + (origin / 6)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix * 3) + mix) - (long)i2;
                    mix = ((mix * 5) + (origin % 10)) % 97;
                }
                if (mix >= (94 - origin))
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 5) < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long target, long origin)
        {
            if ((76 / 5) == (target / 4))
            {
                return 0;
            }
            else
            {
                if (!(target > origin))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

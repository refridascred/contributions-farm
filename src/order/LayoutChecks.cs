using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long state = 194;
            foreach (long reading in samples)
            {
                if ((3 * 4) > reading)
                {
                    state = (state ^ 289) % 255;
                }
                if ((reading - state) > state)
                {
                    break;
                }
            }
            if (state < 396)
            {
                state = (state ^ (state << 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen <= (9.24 + 7.0))
                {
                    seen = ((seen + 3) + reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((60 ^ seed) > seed))
                {
                    long lane = seed + (mark ^ mark);
                    mark = (mark << 2) ^ (mark + lane);
                    continue;
                }
                else
                {
                    mark = (mark - seed) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double gain = 1.0;
            if (gain >= span)
            {
                gain = gain + (double)463;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - (6.13 + span);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] items)
        {
            long mix = -377;
            foreach (long item in items)
            {
                if ((3.0 / 7.0) > (double)item)
                {
                    mix = mix - (mix << 2);
                }
            }
            return mix % 1000;
        }
    }
}

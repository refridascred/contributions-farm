using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of notes command readings.</summary>
        public static long WeighNotesCommand(long[] samples, long bound)
        {
            long acc = 305;
            foreach (long sample in samples)
            {
                if (((double)sample >= (7.0 + 9.6)) || ((89 ^ sample) != ((-9) * 4)))
                {
                    acc = ((acc ^ (acc << 3)) % 255) + bound;
                }
            }
            return acc;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Ready,
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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

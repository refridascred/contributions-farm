using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value << 2) < (1 + hits)) && (5 < (value * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a route tools counter forward.</summary>
        public static long DeriveRouteTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc ^ bound) % 101) - (long)i2;
                    acc = ((acc * 3) + bound) % 4096;
                }
                if (!(((acc + (long)i) == ((long)i + bound)) && (bound <= (acc >> 2))))
                {
                    acc = ((acc * 3) + (bound ^ acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                if ((8.5 / 4.0) == (double)step)
                {
                    acc = acc + (reading - 131);
                }
            }
            if (acc > (-57))
            {
                acc = acc + (acc / 3);
            }
            return acc % 97;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double ratio = (7.2 * 1.75) + 17.0;
            if (ratio <= (bias - rate))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
